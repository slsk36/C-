using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookManager
{
    class DataManager
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        static DataManager() 
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                string booksOutput = File.ReadAllText(@"./Books.xml");
                XElement booksXElement = XElement.Parse(booksOutput);
                Books = (from item in booksXElement.Descendants("book")
                         select new Book()
                         {
                             Isbn = item.Element("isbn").Value,
                             Name = item.Element("name").Value,
                             Publisher = item.Element("publisher").Value,
                             Page = int.Parse(item.Element("page").Value),
                             BorrowedAt = DateTime.Parse(item.Element("borrowedAt").Value),
                             isBorrowed = item.Element("isBorrowed").Value != "0" ? true : false,
                             UserId = int.Parse(item.Element("userId").Value),
                             UserName = item.Element("userName").Value
                         }).ToList<Book>();

                string userOutput = File.ReadAllText(@".Users.xml");
                XElement usersXElement = XElement.Parse(userOutput);
                Users = (from item in usersXElement.Descendants("user")
                         select new User()
                         {
                             Id = int.Parse(item.Element("id").Value),
                             Name = item.Element("name").Value
                         }).ToList<User>();
            }
            catch(FileLoadException exception) {
                Save();
            }
        }

        public static void Save()
        {
            string booksOutPut = "";
            booksOutPut += "<books>\n";
            foreach(var item in Books) {
                booksOutPut += "<book>\n";
                booksOutPut += " <isbn>" + item.Isbn + "</isbn>\n";
                booksOutPut += " <name>" + item.Name + "</name>\n";
                booksOutPut += " <publisher>" + item.Publisher + "</publisher>\n";
                booksOutPut += " <page>" + item.Page + "</page>\n";
                booksOutPut += " <borrowedAt>" + item.BorrowedAt.ToLongDateString() + "</borrowedAt>\n";
                booksOutPut += " <isBorrowed>" + (item.isBorrowed ? 1:0) + "</isBorowed>\n";
                booksOutPut += "<userId>" + item.UserId + "</userId>\n";
                booksOutPut += "<userName>" + item.UserName + "</userName>\n";
                booksOutPut += "</book>\n";
            }
            booksOutPut += "</books>";

            string userOutput = "";
            userOutput += "<users>\n";
            foreach(var item in Users) {
                userOutput += "<users>\n";
                userOutput += " <id>" + item.Id + "</id>\n";
                userOutput += " <name>" + item.Name + "</name>\n";
                userOutput += " </user>\n";
            }
            userOutput += "</users>";

            File.WriteAllText(@"./Books.xml", booksOutPut);
            File.WriteAllText(@"./Users.xml", userOutput);

        }
    }
}
