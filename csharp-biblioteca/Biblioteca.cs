using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {
        public List<User> Users { get; set; } = new();
        public List<Document> Documents { get; set; } = new();
        public List<Loan> Loans { get; set; } = new(); 


        public void PrendiInPrestito(User user, Document document, DateTime dateStart, DateTime dateEnd)
        {
            Loans.Add(new Loan(user, document, dateStart, dateEnd));
        }
        public string SearchDocument(int input, Biblioteca biblioteca)
        {
            foreach (Document document in biblioteca.Documents)
            {
                if (document.Code == input)
                {
                    return document.Code.ToString();
                }
            }
            return "Nessun risultato";

        }
        public string SearchDocument(string input, Biblioteca biblioteca)
        {
            foreach (Document document in biblioteca.Documents)
            {
                if (document.Title == input)
                {
                    return document.Code.ToString();
                }
            }
            return "Nessun risultato";
        }

    }
    public class User
    {
        private string _surname;
        private string _name;
        private string _email;
        private string _password;
        private int _phone;

        public string Surname { get { return _surname; } set { _surname = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public int Phone { get { return _phone; } set { _phone = value; } }

        public User(string surname, string name, string email, string password, int phone, Biblioteca biblioteca)
        {
            this._surname = surname;
            this._name = name;
            this._email = email;
            this._password = password;
            this._phone = phone;
            biblioteca.Users.Add(this);
        }
    }
    public class Document
    {
        private int _code;
        private string _title;
        private int _year;
        private string _sector;
        private string _position;
        private string _author;

        public int Code { get { return _code; } set { _code = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        public string Sector { get { return _sector; } set { _sector = value; } }
        public string Position { get { return _position; } set { _position = value; } }
        public string Author { get { return _author; } set { _author = value; } }

        public Document(int code, string title, int year, string sector, string position, string author, Biblioteca biblioteca)

        {
            this._code = code;
            this._title = title;
            this._year = year;
            this._sector = sector;
            this._position = position;
            this._author = author;
            biblioteca.Documents.Add(this);
        }
    }

    public class Loan
    {
        public User User { get; set; }
        public Document Document { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }

        public Loan(User user, Document document, DateTime dateStart, DateTime dateEnd) 
        {
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.User = user;
            this.Document = document;
        }
    }
    public class Book : Document
    {
        private int _numberPage;

        public int NumberPage { get { return _numberPage; } set { _numberPage = value; } }

        public Book(int code, string title, int year, string sector, string position, string author, int numberPage, Biblioteca biblioteca)
            : base(code, title, year, sector, position, author, biblioteca)
        {
            this._numberPage = numberPage;
        }
    }
    public class DVD : Document
    {
        private int _duration;

        public int Duration { get { return _duration; } set { _duration = value; } }

        public DVD(int code, string title, int year, string sector, string position, string author, int duration, Biblioteca biblioteca)
            : base(code, title, year, sector, position, author, biblioteca)
        {
            this._duration = duration;
        }
    }
}
