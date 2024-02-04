using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Libraru.Models
{
    internal class DataBase : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=ПОЛНЫЙ ПУТЬ ДО DATABASE.MDF;Integrated Security=True;Connect Timeout=30";
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Return> Returns { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
        public static void AddBook(string name, string description, int count)
        {
            using (DataBase db = new())
            {
                Book book = new()
                {
                    Name = name,
                    Description = description,
                    Count = count
                };
                db.Books.Add(book);
                db.SaveChanges();
            }
        }
        public static void RemoveBook(int id)
        {
            using (DataBase db = new())
            {
                Book book = db.Books.FirstOrDefault(el => el.Id == id);
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }
        public static void AddUser(string firstName, string lastName, string year, string email)
        {
            using (DataBase db = new())
            {
                User user = new()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Year = year,
                    Email = email
                };
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public static void RemoveUser(int id)
        {
            using (DataBase db = new())
            {
                User user = db.Users.FirstOrDefault(el => el.Id == id);
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
        public static void AddContract(int bookId, int userId, string date, string time)
        {
            using (DataBase db = new())
            {
                Book book = db.Books.FirstOrDefault(el => el.Id == bookId);
                book.Count--;
                db.Books.Update(book);
                Contract contract = new()
                {
                    BookId = bookId,
                    UserId = userId,
                    Date = date,
                    Time = time
                };
                db.Contracts.Add(contract);
                db.SaveChanges();
            }
        }
        public static void RemoveContract(int id)
        {
            using (DataBase db = new())
            {
                Contract contract = db.Contracts.FirstOrDefault(el => el.Id == id);
                db.Contracts.Remove(contract);
                db.SaveChanges();
            }
        }
        public static void AddReturn(int contractId, bool delay)
        {
            using (DataBase db = new())
            {
                Contract contract = db.Contracts.FirstOrDefault(el => el.Id == contractId);
                Book book = db.Books.FirstOrDefault(el => el.Id == contract.BookId);
                book.Count++;
                db.Books.Update(book);
                Return _return = new()
                {
                    ContractId = contractId,
                    Delay = delay
                };
                db.Returns.Add(_return);
                db.SaveChanges();
            }
        }
        public static void RemoveReturn(int id)
        {
            using (DataBase db = new())
            {
                Return _return = db.Returns.FirstOrDefault(el => el.Id == id);
                db.Returns.Remove(_return);
                db.SaveChanges();
            }
        }
    }
}
