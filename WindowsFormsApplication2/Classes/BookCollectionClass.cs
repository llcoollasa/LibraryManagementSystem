using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    public class BookCollectionClass
    {
        private List<BookClass> booksCollection;

        public BookCollectionClass()
        {
            this.booksCollection = new List<BookClass>();
        }

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
    }
}
