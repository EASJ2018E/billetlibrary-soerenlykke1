using System;

namespace BilletLibrary
{
    public abstract class Koeretoej
    {
        private string _nummerplade;

        public virtual string Nummerplade
        {
            get { return _nummerplade; }
            set { _nummerplade = value; }
        }

        public virtual DateTime Date { get; set; }

        public virtual double Rabat { get; set; }

        /// <summary>
        /// En metode som retuner prisen som double.
        /// </summary>
        /// <returns></returns>
        abstract public double Pris();


        /// <summary>
        /// En metode som retunere hvilket køretøj det er.
        /// </summary>
        /// <returns></returns>
        abstract public string Køretøj();


        abstract public double Brobizz();

        
        virtual public double StandardRabat()
        {
            return 0.95;
        }


    }
}