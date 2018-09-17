using System;

namespace BilletLibrary
{
    public class MC : Koeretoej
    {
        public string Nummerplade { get; set; }
        public DateTime Date { get; set; }


        /// <summary>
        /// En metode som retuner prisen som decimal.
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// En metode som retunere hvilket køretøj det er (Bil).
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "MC";
        }
    }
}