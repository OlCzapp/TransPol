using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransPol
{
    internal class SamochodOsobowy : Pojazdy
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
}
