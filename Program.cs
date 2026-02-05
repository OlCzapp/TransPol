class Program
{
       static void Main(string[] args)
    {
        // lista obiektó typu pojazd
        // przynajmniej 1 osobowy 1 ciezarowy
        // foreach przechodzi po liście i wyświetla dane z metody WyswietlInfomracje() dla danego pojazdu
    }
}
class Pojazd
{
    static void Main(string[] args)
    {

    }
    private string marka;
    private string model;
    private int rokProdukcji;

    public Pojazd(string marka, string model, int rokProdukcji)
    {
        this.marka = "";
        this.model = "";
        this.rokProdukcji = 0;
    }
}

class SamochodOsobowy : Pojazd
{
    private string lizbaDrzwi;
    // wywołanie konstruktora klasy bazowej Pojazd
    // podanie danych do WyswietlInfomracje()
}

class Ciezarowka : Pojazd
{
    private string ladownoscTon;
    // wywołanie konstruktora klasy bazowej Pojazd
    // podanie danych do WyswietlInfomracje()
}