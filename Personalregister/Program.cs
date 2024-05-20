namespace Personalregister
{
    internal class Program
    {
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

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Välkommen, kan du fylla i ditt namn: ");

            string namn = Console.ReadLine();
            Console.WriteLine(namn);
            Console.WriteLine("och din lön: ");
            string lon = Console.ReadLine();



            Console.WriteLine(lon, namn); 
        }
    }
}
