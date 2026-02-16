using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransPol
{
    internal class SamochodOsobowy : Pojazdy // dziedziczy po pojazdach
    {
        private string lizbaDrzwi; // string tylko dla tej klasy

        // wywołanie konstruktora klasy bazowej Pojazd
        public SamochodOsobowy(string marka, string model, int rokProdukcji, string liczbaDrzwi) : base(marka, model, rokProdukcji) // base - co było w dziedziczonej klasie
        {
            this.lizbaDrzwi = liczbaDrzwi; // bierzemy stąd liczbę drzwi i przypisujemy do końcowych parametrów
        }

        // podanie danych do WyswietlInfomracje()
        public override string WyswietlInformacje() // override - dopisz do WyswietlInformacje()
        {
            return "Samochód osobowy: " + base.WyswietlInformacje() + $", Liczba drzwi: {lizbaDrzwi}"; // najpiew nazwa do czego jest ta konkretna klasa, wszystko z klasy pojazdy, przypisana nowa zmienna
        }
    }
}
