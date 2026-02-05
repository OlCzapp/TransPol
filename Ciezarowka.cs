using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransPol
{
    internal class Ciezarowka : Pojazdy
    {
        private int ladownoscTon;
        // wywołanie konstruktora klasy bazowej Pojazd
        public Ciezarowka(string marka, string model, int rokProdukcji, int ladownoscTon) : base(marka, model, rokProdukcji)
        {
            this.ladownoscTon = ladownoscTon;
        }

        // podanie danych do WyswietlInfomracje()
        public override string WyswietlInformacje()
        {
            return "Ciężarówka: " + base.WyswietlInformacje() + $", Ładowność: {ladownoscTon} ton";
        }
    }
}
