using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    public class BookClass
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
        private double cost;

        public double Cost
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
    }
}
