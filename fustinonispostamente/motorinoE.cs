using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fustinonispostamente
{
    class motorinoE:veicolo
    {
        protected string targa;
        protected float livellobatteria;
        protected bool radio;
        protected float costoH;
        protected float costoD;

        public motorinoE()
        {
            targa = "";
            livellobatteria = 0;
            radio = false;
            costoH = 0;
            costoD = 0;
       
        }
        public motorinoE(string identificativo, string marca, int stato, bool disponibilita, double latitudine, double longitudine, float costoMinuto, int posti, string targa, float livellobatteria, bool radio, float costoH, float costoD) : base(identificativo, marca, stato, disponibilita, latitudine, longitudine, costoMinuto, posti)
        {
            this.targa = targa;
            this.livellobatteria = livellobatteria;
            this.radio = radio;
            this.costoH = costoH;
            this.costoD = costoD;
        }
        public new void getAll()
        {
            base.getAll();
            Console.Write("targa: "); Console.Write(this.targa); Console.WriteLine();
            Console.Write("livellobatteria: "); Console.Write(this.livellobatteria); Console.WriteLine();
            Console.Write("radio: "); Console.Write(this.radio); Console.WriteLine();
            Console.Write("costoH: "); Console.Write(this.costoH); Console.WriteLine();
            Console.Write("costoD: "); Console.Write(this.costoD); Console.WriteLine();
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
                if (value >-1)
                {
                    livellobatteria = value;
                }
            }
            get
            {
                return livellobatteria;
            }
        }
        public override bool opsional1 
        {
            set
            {
                
                    radio = value;
             
            }
            get
            {
                return radio;
            }
        }
        public override float cOra
        {
            set
            {
                if (value >0)
                {
                    costoH = value;
                }
            }
            get
            {
                return costoH;
            }
        }
        public override float cGiorno
        {
            set
            {
                if (value >0)
                {
                        costoD = value;
                }
            }
            get
            {
                return costoD;
            }
        }
    }
}
