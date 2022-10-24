using Dzejson.Models;

namespace Dzejson
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Argumenty
            //2. Kolekcje
            List<int> list = new List<int>();
            HashSet<int> set = new HashSet<int>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            //3. Klasa modelowa - Student
            //object initializer
            Student s = new Student
            {
                FirstName = "John",
                LastName = "Kowalski"
            };

            //4. Wczytywanie/zapisywanie danych

            string str = File.ReadAllText("path");
            

            FileInfo fi = new FileInfo("path");

            StreamReader stream = new StreamReader(fi.OpenRead());

        }
    }
}