using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    public class BorrowingClass
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
        private int fine;

        public int Fine
        {
            get { return fine; }
            set { fine = value; }
        }
    }
}
