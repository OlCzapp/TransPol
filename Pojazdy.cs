using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransPol
{
    internal class Pojazdy : Program // dziedziczy po class Program wartości
    {
        // daje miejsce na dane do marki, modelu i roku produkjci - prywatne bo widoczne tylko dla dziedziczących
            private string marka;
            private string model;
            private int rokProdukcji;

        // przypisanie do istniejących metod
            public Pojazdy(string marka, string model, int rokProdukcji)
            {
                this.marka = marka;
                this.model = model;
                this.rokProdukcji = rokProdukcji;
            }

        // do WyswietlInformacje() dodaje schludny opis powyższych elementów przypisując dane parametry
            public virtual string WyswietlInformacje()
            {
                return $"Marka: {marka}, Model: {model}, Rok produkcji: {rokProdukcji}";
            }
        
    }
}
