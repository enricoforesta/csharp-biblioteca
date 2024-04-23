

// using static csharp_biblioteca.Biblioteca.Document;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca bibliotecaBella = new Biblioteca();
            User Luca = new User("luchetto", "luca", "luca@luca", "******", 351447789);
            bibliotecaBella.AddUser(Luca);

            Book Libro = new Book(0001,"Libro1 bello",1599,"storia","14A","Luca",5);
            bibliotecaBella.AddDocument(Libro);

            Book Libro2 = new Book(0002,"Libro2 bello",1599,"storia","14A","Luca",5);
            bibliotecaBella.AddDocument(Libro2);

            Book Libro3 = new Book(0003,"Libro3 bello",1599,"storia","14A","Luca",5);
            bibliotecaBella.AddDocument(Libro3);

            Book Libro4 = new Book(0004,"Libro4 bello",1599,"storia","14A","Luca",5);
            bibliotecaBella.AddDocument(Libro4);

            DVD Dvd = new DVD(1001,"Dvd bello",1599,"storia","14A","Luca",120);
            bibliotecaBella.AddDocument(Dvd);

            DVD Dvd2 = new DVD(1002,"Dvd2 bello",1599,"storia","14A","Luca",120);
            bibliotecaBella.AddDocument(Dvd2);

            DVD Dvd3 = new DVD(1003,"Dvd3 bello",1599,"storia","14A","Luca",120);
            bibliotecaBella.AddDocument(Dvd3);

            DVD Dvd4 = new DVD(1004,"Dvd4 bello",1599,"storia","14A","Luca",120);
            bibliotecaBella.AddDocument(Dvd4);

           Console.WriteLine(bibliotecaBella.SearchDocument(1002)) ;
            bibliotecaBella.PrendiInPrestito(Luca, Dvd4, new DateTime(2024, 3, 12), new DateTime(2024, 3, 30));
        }
    }
}
