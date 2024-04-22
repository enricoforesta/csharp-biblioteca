

// using static csharp_biblioteca.Biblioteca.Document;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User Luca = new User("luchetto", "luca", "luca@luca", "******", 351447789);
            Book libro = new Book(0001,"Libro1 bello",1599,"storia","14A","Luca",5);
            Book libro2 = new Book(0002,"Libro2 bello",1599,"storia","14A","Luca",5);
            Book libro3 = new Book(0031,"Libro3 bello",1599,"storia","14A","Luca",5);
            Book libro4 = new Book(0004,"Libro4 bello",1599,"storia","14A","Luca",5);
            DVD Dvd = new DVD(1001,"Dvd bello",1599,"storia","14A","Luca",120);
            DVD Dvd2 = new DVD(1002,"Dvd2 bello",1599,"storia","14A","Luca",120);
            DVD Dvd3 = new DVD(1003,"Dvd3 bello",1599,"storia","14A","Luca",120);
            DVD Dvd4 = new DVD(1004,"Dvd4 bello",1599,"storia","14A","Luca",120);
        }
    }
}
