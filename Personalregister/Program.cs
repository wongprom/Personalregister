using System.Security.Cryptography.X509Certificates;

namespace Personalregister
{
    internal class Program
    {
        class Person
        {
            public string Namn { get; set; } = string.Empty;
            public int Lon { get; set; }
        }
        static void Main(string[] args)
        {
            //Uppgift 1
            //Vilka klasser bör ingå i programmet?
            //Svar: person

            //Uppgift 2
            //Vilka attribut och metoder bör ingå i dessa klasser?
            // attribut = namn, lön
            // metoder = vet ej än

            //Uppgift 3
            //Skriv programmet

            List<Person> personalregister = new List<Person>();
            bool laggaTillNyPerson = true;
            while (laggaTillNyPerson)
            {
                Console.WriteLine("Skriv ditt namn: ");
                string namn = Console.ReadLine();
                Console.WriteLine(namn);
                Console.WriteLine("Skriv din lön: ");
                string lon = Console.ReadLine();
                int antalAnstallda = personalregister.Count;
                Console.WriteLine(antalAnstallda);

                Person person = new Person
                {
                    Namn = namn,
                    Lon = Int32.Parse(lon)
                };

                personalregister.Add(person);

                
            }
            
        }
    }
}
