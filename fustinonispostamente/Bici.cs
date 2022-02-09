using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fustinonispostamente
{
    class Bici:veicolo
    {
        
        protected string tipologia;
        protected char dimensione;
        protected bool casco;
        protected bool seggiolino;
        protected float costoSblocco;
        protected float costoH;
        protected float costoD;


        public Bici()
        {
            tipologia = "";
            dimensione = ' ';
            casco = false;
            seggiolino = false;
            costoSblocco = 0;
            costoH = 0;
            costoD = 0;
        }

        public Bici(string identificativo, string marca, int stato, bool disponibilita, double latitudine, double longitudine, float costoMinuto, int posti,string tipologia, char dimensione, bool casco, bool seggiolino, float costoSblocco, float costoH, float costoD) : base(identificativo, marca, stato,  disponibilita, latitudine, longitudine, costoMinuto, posti)
        {
            this.tipologia = tipologia;
            this.dimensione = dimensione;
            this.casco = casco;
            this.seggiolino = seggiolino;
            this.costoSblocco = costoSblocco;
            this.costoH = costoH;
            this.costoD = costoD;
        }

        public new void getAll()
        {
            base.getAll();
            Console.Write("tipologia: "); Console.Write(this.tipologia); Console.WriteLine();
            Console.Write("dimensione: "); Console.Write(this.dimensione); Console.WriteLine();
            Console.Write("Scuola: "); Console.Write(this.casco); Console.WriteLine();
            Console.Write("seggiolino: "); Console.Write(this.seggiolino); Console.WriteLine();
            Console.Write("costoSblocco: "); Console.Write(this.costoSblocco); Console.WriteLine();
            Console.Write("costoH: "); Console.Write(this.costoH); Console.WriteLine();
            Console.Write("costoD: "); Console.Write(this.costoD); Console.WriteLine();
        }

        /*  public  string Tipologia
          {
              set
              {
                  if (value is string)
                  {
                      tipologia = value;
                  }
              }
              get
              {
                  return tipologia;
              }
          }*/
        public override char dim 
        {
            set
            {
                if (value=='M'|| value == 'm'|| value == 'S' || value == 's' || value == 'L' || value == 'l')
                {
                    dimensione = value;
                }
            }
            get
            {
                return dimensione;
            }
        }

        public override bool opsional1 
        {
            set
            {
                    casco = value;
            }
            get
            {
                return casco;
            }
        }
        public override bool opsional2
        {
            set
            {

                seggiolino = value;
            }
            get
            {
                return seggiolino;
            }
        }
        public override float cSblocco
        {
            set
            {
                if (value >0)
                {
                    costoSblocco = value;
                }
            }
            get
            {
                return costoSblocco;
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
