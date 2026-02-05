using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransPol
{
    internal class Pojazdy : Program
    {
            private string marka;
            private string model;
            private int rokProdukcji;

            public Pojazdy(string marka, string model, int rokProdukcji)
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
}
