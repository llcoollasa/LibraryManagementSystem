using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace LibraryManagementSystem
{
    public class BookCollectionClass : BookClass
    {
        private List<BookClass> booksCollection;

        public List<BookClass> BooksCollection
        {
            get { return booksCollection; }
            set { booksCollection = value; }
        }

        /// <summary>
        /// Add Book in to the book collection
        /// </summary>
        public void addBook(BookClass book)
        {
            this.booksCollection.Add(book);
        }

        /// <summary>
        /// Add all books to the collection
        /// </summary>
        public void addBooks()
        {
            ArrayList books = new ArrayList();
            books = this.getAll();

            foreach (BookClass item in books)
            {
                addBook(item);
            }
        }

        public BookCollectionClass()
        {
            this.booksCollection = new List<BookClass>();
        }

        /// <summary>
        /// Sort Books by Category
        /// </summary>
        /// <param name="Books"></param>
        public void sortBook()
        { 
            for (int iterator = 0; iterator < this.booksCollection.Count; iterator++)
            {
                for (int index = 0; index < this.booksCollection.Count - 1; index++)
                {
                    if (this.booksCollection[index].Category.CategoryId > this.booksCollection[index + 1].Category.CategoryId)
                    {
                        BookClass tempBook = null;
                        tempBook = this.booksCollection[index];
                        this.booksCollection[index] = this.booksCollection[index + 1];
                        this.booksCollection[index + 1] = tempBook;
                    }
                }
            }
        }

        public void SerializeBooks(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(DataSet));
            DataSet ds = new DataSet("BooksDataSet");
            DataTable dt = Program.db.getResult("SELECT * FROM book");
            ds.Tables.Add(dt);
            TextWriter writer = new StreamWriter(filename);
            ser.Serialize(writer, ds);
            writer.Close();
        } 
    }
}
