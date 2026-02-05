class Program
{
    static void Main(string[] args)
    {
        List<Pojazd> pojazdy = new List<Pojazd>();

        // Samochody Osobowe
        pojazdy.Add(new SamochodOsobowy("Toyota", "Corolla", 2020, "4"));
        pojazdy.Add(new SamochodOsobowy("Honda", "Civic", 2019, "2"));
        // Ciężarówki
        pojazdy.Add(new Ciezarowka("Volvo", "FH16", 2018, 25));
        pojazdy.Add(new Ciezarowka("Scania", "R500", 2021, 30));


        // foreach przechodzi po liście i wyświetla dane z metody WyswietlInfomracje() dla danego pojazdu
        foreach (Pojazd element in pojazdy)
        {
            Console.WriteLine(element.WyswietlInformacje());
        }
    }
}
class Pojazd
{
    private string marka;
    private string model;
    private int rokProdukcji;

    public Pojazd(string marka, string model, int rokProdukcji)
    {
        this.marka = marka;
        this.model = model;
        this.rokProdukcji = rokProdukcji;
    }

    public virtual string WyswietlInformacje()
    {
        return $"Marka: {marka}, Model: {model}, Rok produkcji: {rokProdukcji}";
    }
}

class SamochodOsobowy : Pojazd
{
    private string lizbaDrzwi;
    
    // wywołanie konstruktora klasy bazowej Pojazd
    public SamochodOsobowy(string marka, string model, int rokProdukcji, string liczbaDrzwi) : base(marka, model, rokProdukcji)
    {
        this.lizbaDrzwi = liczbaDrzwi;
    }

    // podanie danych do WyswietlInfomracje()
    public override string WyswietlInformacje()
    {
        return "Samochód osobowy: " + base.WyswietlInformacje() + $", Liczba drzwi: {lizbaDrzwi}";
    }
}

class Ciezarowka : Pojazd
{
    private int ladownoscTon;
    // wywołanie konstruktora klasy bazowej Pojazd
    public Ciezarowka(string marka, string model, int rokProdukcji, int ladownoscTon) : base (marka, model, rokProdukcji)
    {
        this.ladownoscTon = ladownoscTon;
    }

    // podanie danych do WyswietlInfomracje()
    public override string WyswietlInformacje()
    {
        return "Ciężarówka: "+ base.WyswietlInformacje() + $", Ładowność: {ladownoscTon} ton";
    }
}