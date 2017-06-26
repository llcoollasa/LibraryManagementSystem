using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagementSystem.Classes;
using System.Collections;
using System.Data;

namespace LibraryManagementSystem
{
    public class MemberClass : ICRUDOperations
    {
        private int member_id;

        public int MemberId
        {
            get { return member_id; }
            set { member_id = value; }
        }
        private string first;

        public string First
        {
            get { return first; }
            set { first = value; }
        }
        private string last;

        public string Last
        {
            get { return last; }
            set { last = value; }
        }
        private DateTime registered_date;

        public DateTime RegisteredDate
        {
            get { return registered_date; }
            set { registered_date = value; }
        }
        private Boolean active;

        public Boolean Active
        {
            get { return active; }
            set { active = value; }
        }

        public int save()
        {
            String sql = "INSERT INTO member(first, last, registered_date, active) " +
                "VALUES('" + this.first + "', '" + this.last + "', '" + this.registered_date + "', '" + this.active + "')";
            return Program.db.executeNonQuery(sql);
        }

        public int update()
        {
            String sql = "UPDATE member SET first = '" + this.first + "', last='" + this.last + "', registered_date='" + this.registered_date +
                "', active='" + this.active +  "' WHERE member_id = " + this.member_id;
            return Program.db.executeNonQuery(sql);
        }

        public int delete()
        {
            String sql = "DELETE FROM member WHERE member_id = " + this.member_id;
            return Program.db.executeNonQuery(sql);
        }

        public bool get()
        {
            bool result = false;
            String sql = "SELECT * FROM member WHERE member_id = " + this.member_id;
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            if (dt.Rows.Count > 0)
            {
                this.First = dt.Rows[0].Field<String>("first");
                this.Last = dt.Rows[0].Field<String>("last");
                this.RegisteredDate = dt.Rows[0].Field<DateTime>("registered_date"); 
                this.Active = dt.Rows[0].Field<bool>("active");
                result = true;
            }
            return result;

        }

        public ArrayList getAll()
        {
            String sql = "SELECT * FROM member";
            return makeCollection(sql);
        }

        public ArrayList search(Dictionary<string, string> parameters)
        {
            String sql = "SELECT * FROM member WHERE ";
            sql = Program.db.prepareSearchSql(parameters, sql);
            return makeCollection(sql);
        }


        public ArrayList makeCollection(String sql)
        {
            ArrayList memberCollection = new ArrayList();
            DataTable dt = new DataTable();
            dt = Program.db.getResult(sql);

            //add member to list
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    MemberClass member = new MemberClass();
                    member.MemberId = item.Field<Int32>("member_id");
                    member.First = item.Field<String>("first");
                    member.Last = item.Field<String>("last");
                    member.RegisteredDate = item.Field<DateTime>("registered_date");
                    member.Active = item.Field<bool>("active");
                    memberCollection.Add(member);
                }
            }
            return memberCollection;
        }
    }
}
