using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagementSystem.Classes;
using System.Collections;
using System.Data;

namespace LibraryManagementSystem
{
    public class BookClass : ICRUDOperations
    {
        private int book_id;

        public int BookId
        {
            get { return book_id; }
            set { book_id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private DateTime publication_date;

        public DateTime PublicationDate
        {
            get { return publication_date; }
            set { publication_date = value; }
        }
        private Boolean available;

        public Boolean Available
        {
            get { return available; }
            set { available = value; }
        }
        private decimal cost;

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private DateTime purchase_date;

        public DateTime PurchaseDate
        {
            get { return purchase_date; }
            set { purchase_date = value; }
        }
        private string purchase_bill_no;

        public string PurchaseBillNo
        {
            get { return purchase_bill_no; }
            set { purchase_bill_no = value; }
        }
        private CategoryClass category;

        public CategoryClass Category
        {
            get { return category; }
            set { category = value; }
        }

        public int save()
        {
            String sql = "INSERT INTO book(name, author, publisher, publication_date,available,cost,purchase_date,purchase_bill_no,cat_id) "+
                "VALUES('" + this.name + "', '" + this.author + "', '" + this.publisher + "', '" + this.publication_date + "', '" + this.available +
                "', " + this.cost + ", '" + this.purchase_date + "', '" + this.purchase_bill_no + "', '" + this.category.CategoryId + "')";
            return Program.db.executeNonQuery(sql);
        }

        public int update()
        {
            String sql = "UPDATE book SET name = '" + this.name + "', author='" + this.author + "', publisher='" + this.publisher +
                "' , publication_date='" + this.publication_date + "', available='" + this.available + "', cost=" + this.cost +
                ", purchase_date='" + this.purchase_date + "' , purchase_bill_no='" + this.purchase_bill_no + "'" +
                ", cat_id=" + this.category.CategoryId + " WHERE book_id = " + this.book_id;
            return Program.db.executeNonQuery(sql);
        }

        public int delete()
        {
            String sql = "DELETE FROM book WHERE book_id = " + this.book_id;
            return Program.db.executeNonQuery(sql);
        }

        public bool get()
        {
            bool result = false;
            String sql = "SELECT * FROM book WHERE book_id = " + this.book_id;
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            if (dt.Rows.Count > 0)
            {
                //assign values 
                this.Name = dt.Rows[0].Field<String>("name");
                this.Author = dt.Rows[0].Field<String>("author");
                this.Publisher = dt.Rows[0].Field<String>("publisher");
                this.PublicationDate = dt.Rows[0].Field<DateTime>("publication_date");
                this.Available = dt.Rows[0].Field<bool>("available");
                this.Cost = dt.Rows[0].Field<decimal>("cost");
                this.PurchaseDate = dt.Rows[0].Field<DateTime>("purchase_date");
                this.PurchaseBillNo = dt.Rows[0].Field<String>("purchase_bill_no");

                //Assign Category
                this.category = new CategoryClass();
                this.category.CategoryId = dt.Rows[0].Field<Int32>("cat_id");
                this.category.get();
                result = true;
            }
            return result;
        }

        public ArrayList getAll()
        {
            String sql = "SELECT * FROM book";
            return makeCollection(sql);
        }

        public ArrayList search(Dictionary<string, string> parameters)
        {
            String sql = "SELECT * FROM book WHERE ";
            sql = Program.db.prepareSearchSql(parameters, sql);
            return makeCollection(sql);
        }

        public ArrayList makeCollection(String sql)
        {
            ArrayList bookCollection = new ArrayList();
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            //add member to list
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    BookClass book = new BookClass();
                    book.BookId = item.Field<Int32>("book_id");
                    book.Name = item.Field<String>("name");
                    book.Author = item.Field<String>("author");
                    book.Publisher = item.Field<String>("publisher");
                    book.PublicationDate = item.Field<DateTime>("publication_date");
                    book.Available = item.Field<bool>("available");
                    book.Cost = item.Field<decimal>("cost");
                    book.PurchaseDate = item.Field<DateTime>("purchase_date");
                    book.PurchaseBillNo = item.Field<String>("purchase_bill_no");

                    //Assign Category
                    book.category = new CategoryClass();
                    book.category.CategoryId = item.Field<Int32>("cat_id");
                    book.category.get();

                    bookCollection.Add(book);
                }
            }
            return bookCollection;
        }

    }
}
