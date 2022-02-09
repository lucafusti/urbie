using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fustinonispostamente
{
    public class Monopattino:veicolo
    {
        private float livellobatteria;
        private bool segnaleacustico;
        private float batteriaMassima;
        private float costoH;
        private float costoD;

        public Monopattino()
        {
            livellobatteria = -1;
            segnaleacustico = false;
            costoH = -1;
            costoD = -1;
        }

        public Monopattino(string identificativo, string marca, int stato, bool disponibilita, double latitudine, double longitudine, float costoMinuto, int posti, float livellobatteria, bool segnaleacustico, float batteriaMassima,float costoH, float costoD) : base( identificativo,  marca,  stato,  disponibilita,  latitudine,  longitudine,  costoMinuto,  posti)
        {
            this.livellobatteria = livellobatteria;
            this.segnaleacustico = segnaleacustico;
            this.batteriaMassima = batteriaMassima;
            this.costoH = costoH;
            this.costoD = costoD;
        }


        public override float Batteria 
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    livellobatteria = value;
                }
                else
                {
                    livellobatteria = -1;
                }
            }
            get { return livellobatteria; }
        }

        public override bool opsional1 
        {
            set
            {

                segnaleacustico = value;

            }
            get { return segnaleacustico; }
        }
        public override float cOra 
        {
            set
            {
                if (value > 0)
                {
                    costoH = value;
                }
                else
                {
                    costoH = -1;
                }
            }
            get { return costoH; }
        }
        public override float cGiorno
        {
            set
            {
                if (value > 0)
                {
                    costoD = value;
                }
                else
                {
                    costoD = -1;
                }
            }
            get { return costoD; }
        }
    }
}

