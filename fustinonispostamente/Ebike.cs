using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fustinonispostamente
{
    class Ebike:Bici
    {
        private float caricaBatteria;
        public Ebike()
        {
            caricaBatteria = 0;
        }
        public Ebike(string identificativo, string marca, int stato, bool disponibilita, double latitudine, double longitudine, float costoMinuto, int posti, string tipologia, char dimensione, bool casco, bool seggiolino, int marce, float costoH, float costoD, float caricaBatteria) : base( identificativo,  marca,  stato,  disponibilita,  latitudine,  longitudine,  costoMinuto,  posti,  tipologia,  dimensione,  casco,  seggiolino,  marce,  costoH,  costoD)
        {
            this.caricaBatteria = caricaBatteria; 
        }
        public new void getAll()
        {
            base.getAll();
            Console.Write("caricaBatteria: "); Console.Write(this.caricaBatteria); Console.WriteLine();
        }
        public override float Batteria 
        {
            set
            {
                if (value >=0)
                {
                    caricaBatteria = value;
                }
            }
            get
            {
                return caricaBatteria;
            }
        }

    }
}
