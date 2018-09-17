using System;

namespace BilletLibrary
{
    public abstract class Koeretoej
    {
        public string Nummerplade { get; set; }
        public DateTime Date { get; set; }


        /// <summary>
        /// En metode som retuner prisen som decimal.
        /// </summary>
        /// <returns></returns>
        abstract public decimal Pris();


        /// <summary>
        /// En metode som retunere hvilket køretøj det er (Bil).
        /// </summary>
        /// <returns></returns>
        abstract public string Køretøj();

    }
}