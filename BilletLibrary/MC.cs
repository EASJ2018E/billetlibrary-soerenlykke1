using System;

namespace BilletLibrary
{
    public class MC : Koeretoej
    {
        private string _nummerplade;

        public string Nummerplade
        {
            get { return _nummerplade; }
            set
            {
                if (value.Length < 8)
                {
                    _nummerplade = value;
                }
                else
                {
                    throw new ArgumentException("For mange tal.");
                }
            }
        }

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