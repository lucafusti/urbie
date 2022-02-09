using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fustinonispostamente
{
    public class veicolo
    {
        protected string identificativo;
        protected string marca;
        protected int stato;
        protected bool disponibilita;
        protected double latitudine;
        protected double longitudine;
        protected float costoMinuto;
        protected int posti;


        public veicolo()
        {
            identificativo = "";
            marca = "";
            stato = 0;
            disponibilita = false;
            longitudine = 0;
            latitudine = 0;
            costoMinuto = 0;
            posti = 0;

        }

        public veicolo(string identificativo, string marca, int stato, bool disponibilita, double latitudine, double longitudine, float costoMinuto, int posti)
        {
            this.identificativo = identificativo;
            this.marca = marca;
            this.stato = stato;
            this.disponibilita = disponibilita;
            this.longitudine = longitudine;
            this.latitudine = latitudine;
            this.posti = posti;
            this.costoMinuto = costoMinuto;
        }

        public void getAll()
        {
            Console.Write("Nome: "); Console.Write(this.identificativo); Console.WriteLine();
            Console.Write("Data di nascita: "); Console.Write(this.marca); Console.WriteLine();
            Console.Write("Eta: "); Console.Write(this.stato); Console.WriteLine();
            Console.Write("Sesso: "); Console.Write(this.disponibilita); Console.WriteLine();
            Console.Write("Paese: "); Console.Write(this.longitudine); Console.WriteLine();
            Console.Write("Professione: "); Console.Write(this.latitudine); Console.WriteLine();
            Console.Write("Professione: "); Console.Write(this.posti); Console.WriteLine();
            Console.Write("Professione: "); Console.Write(this.costoMinuto); Console.WriteLine();
        }

        public string Identificativo
        {
            set
            {
                if (value is string)
                {
                    identificativo = value;
                }
            }
            get
            {
                return identificativo;
            }
        }

        public string Marca
        {
            set
            {
                if (value is string)
                {
                    marca = value;
                }
            }
            get
            {
                return marca;
            }
        }
        public int Stato
        {
            set
            {
                if (value > 0 && value < 4)
                {
                    stato = value;
                }
            }
            get
            {
                return stato;
            }
        }

        public bool Disponibilita
        {
            set
            {

                disponibilita = value;

            }
            get
            {
                return disponibilita;
            }
        }

        public double Longitudine
        {
            set
            {
                if (value > 0)//cercare coridinate bergamo
                {
                    longitudine = value;
                }
            }
            get
            {
                return longitudine;
            }
        }
        public double Latitudine//cercare coridinate bergamo
        {
            set
            {
                if (value > 0)
                {
                    latitudine = value;
                }
            }
            get
            {
                return latitudine;
            }
        }
        public int Posti
        {
            set
            {
                if (value > 0)
                {
                    posti = value;
                }
            }
            get
            {
                return posti;
            }
        }
        public float CostoMinuto
        {
            set
            {
                if (value > 0)
                {
                    costoMinuto = value;
                }
            }
            get
            {
                return costoMinuto;
            }
        }

         public virtual string Targa { get; set; }// public override void 

        public virtual float Batteria { get; set; }// public override void 

        public virtual bool opsional1 { get; set; }
        // public override void 

        public virtual bool opsional2 { get; set; }// public override void 
       
        public virtual float cOra { get; set; }// public override void 

        public virtual float cGiorno { get; set; }// public override void 
       
        public virtual float cSblocco { get; set; }// public override void 
      
        public virtual char dim { get; set; }// public override void 
       
    }

    

   
}
