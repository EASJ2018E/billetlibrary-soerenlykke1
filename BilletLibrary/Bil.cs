using System;

namespace BilletLibrary
{
    public class Bil : Koeretoej
    {
        private string _nummerplade;

        public override string Nummerplade
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
            return 240;
        }

        /// <summary>
        /// En metode som retunere hvilket køretøj det er (Bil).
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "Bil";
        }
    }   
}
