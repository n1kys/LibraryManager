using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessForWorkWithData
{
    public class Book
    {
        // Назва книги
        public string Title { get; set; }
        // Автор
        public string Author { get; set; }
        // Жанр
        public string Genre { get; set; }
        // Рік написання
        public int Year { get; set; }
        // Посилання на вебсторінку де можна прочитати книгу
        public string Link { get; set; }
        // Шлях до локального файлу книги на комп'ютері
        public string PathToLocalFile { get; set; }
        // Коментар до книги
        public string Comment { get; set; }
        // id книги
        public int Book_ID { get; set; }
        // список id підсекцій, до яких прив'язана книга
        public List<float> ID_Related_subsections { get; set; }

        /// <summary>
        /// Конструктор для заповнення імені книги, автора, жанру, року написання, посилання на вебсторінку для читання книги, коментаря,
        /// списку id підсекцій, до яких прив'язана книга
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="genre"></param>
        /// <param name="year"></param>
        /// <param name="link"></param>
        /// <param name="comment"></param>
        /// <param name="section"></param>
        public Book(string title, string author, string genre, int year, string link, string comment, List<float> section)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            Link = link;
            Comment = comment;
            ID_Related_subsections = section;
        }

        /// <summary>
        /// Конструктор для заповнення імені книги, автора, жанру, року написання, посилання на вебсторінку для читання книги, 
        /// шляху до локального файлу книги на комп'ютері, коментаря, списку id підсекцій, до яких прив'язана книга 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="genre"></param>
        /// <param name="year"></param>
        /// <param name="link"></param>
        /// <param name="path"></param>
        /// <param name="comment"></param>
        /// <param name="id"></param>
        /// <param name="section"></param>
        public Book(string title, string author, string genre, int year, string link, string path, string comment, int id, List<float> section)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            Link = link;
            PathToLocalFile = path;
            Comment = comment;
            Book_ID = id;
            ID_Related_subsections = section;
        }

        public Book() { }


    }
}
