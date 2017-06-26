﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    public class BorrowingClass : ICRUDOperations 
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private MemberClass member_id;

        public MemberClass MemberId
        {
            get { return member_id; }
            set { member_id = value; }
        }
        private BookClass book_id;

        public BookClass BookId
        {
            get { return book_id; }
            set { book_id = value; }
        }
        private DateTime borrowed_date;

        public DateTime BorrowedDate
        {
            get { return borrowed_date; }
            set { borrowed_date = value; }
        }
        private DateTime returning_date;

        public DateTime ReturningDate
        {
            get { return returning_date; }
            set { returning_date = value; }
        }
        private bool has_return;

        public bool HasReturn
        {
            get { return has_return; }
            set { has_return = value; }
        }
        private decimal fine;

        public decimal Fine
        {
            get { return this.calculateFine(); }
            set { fine = value; }
        }

        private string validation_messages;

        public string ValidationMessages
        {
            get { return validation_messages; }
            set { validation_messages = value; }
        }

        public int save()
        {
            int saved = 0;

            if (this.validateDataBeforeSaveOrUpdate())
            {
                String sql = "INSERT INTO borrowing(book_id,member_id,borrowed_date,returning_date,has_return,fine) VALUES('" + this.BookId.BookId + "','" + this.MemberId.MemberId +
                             "','" + this.BorrowedDate.ToShortDateString() + "', '" + this.ReturningDate.ToShortDateString() + "', '" + this.HasReturn + "', '" + this.Fine + "')";
                saved = Program.db.executeNonQuery(sql);
                this.BookId.Available = this.HasReturn;
                this.BookId.update();
            }

            return saved;
        }

        public int update()
        {
            int updated = 0;

            if (this.validateDataBeforeSaveOrUpdate())
            {
                String sql = "UPDATE borrowing SET book_id = '" + this.BookId.BookId + "', " +
                            " member_id = '" + this.MemberId.MemberId + "', " +
                            " borrowed_date = '" + this.BorrowedDate.ToShortDateString() + "', " +
                            " returning_date = '" + this.ReturningDate.ToShortDateString() + "', " +
                            " has_return = '" + this.HasReturn + "', " +
                            " fine = '" + this.Fine + "' " +
                            " WHERE borrowing_id = " + this.id;
                updated = Program.db.executeNonQuery(sql);
                this.BookId.Available = this.HasReturn;
                this.BookId.update();
            }

            return updated;
            
        }

        public int delete()
        {
            String sql = "DELETE FROM borrowing WHERE borrowing_id = " + this.id;
            return Program.db.executeNonQuery(sql);
        }

        public bool get()
        {
            bool result = false;
            String sql = "SELECT book_id,member_id,borrowed_date,returning_date,has_return,fine FROM borrowing WHERE borrowing_id = " + this.id;
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            if (dt.Rows.Count > 0)
            {
                //Assign Book
                this.BookId = new BookClass();
                this.BookId.BookId = dt.Rows[0].Field<Int32>("book_id");
                this.BookId.get();

                //Assign Member
                this.MemberId = new MemberClass();
                this.MemberId.MemberId = dt.Rows[0].Field<Int32>("member_id");
                this.MemberId.get();
                
                this.BorrowedDate = dt.Rows[0].Field<DateTime>("borrowed_date");
                this.ReturningDate = dt.Rows[0].Field<DateTime>("returning_date");
                this.HasReturn = dt.Rows[0].Field<bool>("has_return");
                this.fine = dt.Rows[0].Field<decimal>("fine");

                result = true;
            }
            return result;

        }

        public ArrayList getAll()
        {
            String sql = "SELECT * FROM borrowing";
            return makeCollection(sql);
        }

        public ArrayList search(Dictionary<string, string> parameters)
        {
            String sql = "SELECT * FROM borrowing WHERE ";
            sql = Program.db.prepareSearchSql(parameters, sql);
            return makeCollection(sql);
        }

        public ArrayList makeCollection(String sql)
        {
            ArrayList borrowingCollection = new ArrayList();
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            //add borrowings to list
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {                   
                    BorrowingClass borrowingClass = new BorrowingClass();
                    borrowingClass.Id = item.Field<Int32>("borrowing_id");

                    //Assign Book
                    borrowingClass.BookId = new BookClass();
                    borrowingClass.BookId.BookId = item.Field<Int32>("book_id");
                    borrowingClass.BookId.get();

                    //Assign Member
                    borrowingClass.MemberId = new MemberClass();
                    borrowingClass.MemberId.MemberId = item.Field<Int32>("member_id");
                    borrowingClass.MemberId.get();

                    borrowingClass.BorrowedDate = item.Field<DateTime>("borrowed_date");
                    borrowingClass.ReturningDate = item.Field<DateTime>("returning_date");
                    borrowingClass.HasReturn = item.Field<bool>("has_return");
                    borrowingClass.fine = item.Field<decimal>("fine");

                    borrowingCollection.Add(borrowingClass);

                }
            }
            return borrowingCollection;

        }

        public ArrayList getCurrentBorrowingsByMember(Int32 member_id, bool hasReturn = false)
        {
            String sql = "SELECT * FROM borrowing WHERE member_id=" + member_id;
            
            if (!hasReturn)
            {
                sql += " AND has_return ='False'";
            }

            return makeCollection(sql);
        }

        public ArrayList getCurrentBorrowingsByBook(Int32 book_id)
        {
            String sql = "SELECT * FROM borrowing WHERE book_id=" + book_id;

            return makeCollection(sql);
        }

        public decimal calculateFine()
        {
            decimal fine = 0;
            decimal noOfDays = 0;

            //get the daily rate
            decimal dailyRate = decimal.Parse(ConfigurationManager.AppSettings["DailyRate"].ToString());

            if (DateTime.Today > this.ReturningDate)
            {
                noOfDays = (decimal)(DateTime.Today - this.ReturningDate).TotalDays;

                if (noOfDays > 0)
                {
                    fine = dailyRate * noOfDays;
                }
                else
                {
                    fine = 0; 
                }
            }
            else 
            {
                fine = 0; 
            }
            return fine;
        }

        private bool validateDataBeforeSaveOrUpdate()
        {
            bool valid = true;

            //validate returning and borrowing dates
            if (this.BorrowedDate >= this.ReturningDate)
            {
                valid = false;
                this.ValidationMessages = "Borrowed date cannot be larger than returning date";
            }

            //validating book availability
            if ( (this.Id == 0 || this.Id == null) &&  !this.BookId.Available)
            {
                valid = false;
                this.ValidationMessages = "Book Is not Available";
            }

            return valid;
        }
    }
}
