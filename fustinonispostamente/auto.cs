using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fustinonispostamente
{
    public class auto:veicolo
    {
        private string targa;
        private float livelloBatteria;
        private float prezzoGiorno;
        private float prezzoOra;
        public auto()
        {
            targa = " ";
            livelloBatteria = 0;
            prezzoGiorno = 0;
            prezzoOra = 0;

        }

        public auto(string identificativo, string marca, int stato, bool disponibilita, double latitudine, double longitudine, float costoMinuto, int posti, string targa, float livelloBatteria, float prezzoGiorno, float prezzoOra) : base(identificativo, marca, stato, disponibilita, latitudine, longitudine, costoMinuto, posti)
        {
            this.targa = targa;
            this.livelloBatteria = livelloBatteria;
            this.prezzoGiorno = prezzoGiorno;
            this.prezzoOra = prezzoOra;
        }
        public new void getAll()
        {
            base.getAll();
            Console.Write("targa: "); Console.Write(this.targa); Console.WriteLine();
            Console.Write("livelloBatteria: "); Console.Write(this.livelloBatteria); Console.WriteLine();
            Console.Write("prezzoGiorno: "); Console.Write(this.prezzoGiorno); Console.WriteLine();
            Console.Write("prezzoOra: "); Console.Write(this.prezzoOra); Console.WriteLine();
        }
        public override string Targa
        {
            set
            {
                if (value is string)
                {
                    targa = value;
                }
            }
            get
            {
                return targa;
            }
        }
        public override float Batteria 
        {
            set
            {
                if (value >=0)
                {
                    livelloBatteria = value;
                }
            }
            get
            {
                return livelloBatteria;
            }
        }
        public override float cGiorno 
        {
            set
            {
                if (value >0)
                {
                    prezzoGiorno = value;
                }
            }
            get
            {
                return prezzoGiorno;
            }
        }
        public override float cOra 
        {
            set
            {
                if (value >0)
                {
                    prezzoOra = value;
                }
            }
            get
            {
                return prezzoOra;
            }
        }
    }
    
}
