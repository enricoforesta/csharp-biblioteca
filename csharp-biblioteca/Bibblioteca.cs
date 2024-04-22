using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Bibblioteca
    {
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

            public User( string surname, string name, string email, string password, int phone) 
            {
                this._surname = surname;
                this._name = name;  
                this._email = email;
                this._password = password;
                this._phone = phone;
            }
        }
        public class Document : User
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

            public Document(string surname, string name, string email, string password, int phone, int code, string title, int year, string sector, string position, string author) 
                :base(surname, name,email,password,phone)
            {
                this._code = code;
                this._title = title;
                this._year = year;
                this._sector = sector;
                this._position = position;
                this._author = author;
            }

            public class Book : Document
            {
                private int _numberPage;

                public int NumberPage { get { return _numberPage; } set { _numberPage = value; } }

                public Book(string surname, string name, string email, string password, int phone, int code, string title, int year, string sector, string position, string author, int numberPage) 
                    : base(surname, name, email, password, phone, code, title, year, sector,position,author)
                {
                    this._numberPage = numberPage;
                   
                }
            }
            public class DVD : Document
            {
                private int _duration;

                public int Duration { get { return _duration; } set { _duration = value; } }

                public DVD(string surname, string name, string email, string password, int phone, int code, string title, int year, string sector, string position, string author, int duration)
                    : base(surname, name, email, password, phone, code, title, year, sector, position, author)
                {
                    this._duration = duration;

                }
            }

        }
    }
}
