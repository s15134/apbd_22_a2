using Dzejson.Models;
using System.Text.Json;

namespace Dzejson
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Argumenty
            string LogFile = "log.txt";
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
            /* 
            try
            {
                string str = File.ReadAllText(@".\Data\dane.csv");
            }
            catch (FileNotFoundException e)
            {
                using(StreamWriter writer = new StreamWriter(LogFile, true))
                {
                    writer.WriteLine("----------------------------");
                    writer.WriteLine("Date: " + DateTime.Now.ToString());
                    writer.WriteLine();

                    while (e != null)
                    {
                        writer.WriteLine(e.GetType().FullName);
                        writer.WriteLine("Message: Brak pliku z danymi");
                        Console.Write("Message: Brak pliku z danymi, przerywam prace");
                        break;
                    }
                }
            }
            
            FileInfo fi = new FileInfo("path");

            StreamReader stream = new StreamReader(fi.OpenRead());
            string line = null;
            while ((line = stream.ReadLine()) != null)
            {

            }
            */
            //5. wykorzystanie HashSet
            HashSet<Student> set2 = new HashSet<Student>();
            Student st = new Student();
            st.FirstName = "Jan";
            Student st2 = new Student();
            st2.FirstName = "Jan";
            set2.Add(st);
            set2.Add(st2);

            //6. jak zapisac do formatu json

            Student st3 = new Student();
            st3.FirstName = "Jan";
            st3.LastName = "Kowalski";
            st3.MotherName = "Katarzyna";

            var jsonString = JsonSerializer.Serialize(st3);
            Console.Write("Helo world");

        }
    }
}