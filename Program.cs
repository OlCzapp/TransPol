using TransPol;

class Program
{
    static void Main(string[] args)
    {
        List<Pojazdy> pojazdy = new List<Pojazdy>();

        // Samochody Osobowe
        pojazdy.Add(new SamochodOsobowy("Toyota", "Corolla", 2020, "4"));
        pojazdy.Add(new SamochodOsobowy("Honda", "Civic", 2019, "2"));
        // Ciężarówki
        pojazdy.Add(new Ciezarowka("Volvo", "FH16", 2018, 25));
        pojazdy.Add(new Ciezarowka("Scania", "R500", 2021, 30));


        // foreach przechodzi po liście i wyświetla dane z metody WyswietlInfomracje() dla danego pojazdu
        foreach (Pojazdy element in pojazdy)
        {
            Console.WriteLine(element.WyswietlInformacje());
        }
    }
}