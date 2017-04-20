using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    public class MemberClass
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
    }
}
