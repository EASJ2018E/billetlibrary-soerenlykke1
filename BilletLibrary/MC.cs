﻿using System;

namespace BilletLibrary
{
    public class MC : Koeretoej
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

        public override DateTime Date { get; set; }

        public override double Rabat { get; set; }

        /// <summary>
        /// En metode som retuner prisen som double.
        /// </summary>
        /// <returns></returns>
        public override double Pris()
        {
            return 125;
        }

        /// <summary>
        /// En metode som retunere hvilket køretøj det er (MC).
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "MC";
        }

        public double StandardRabat()
        {
            return base.StandardRabat();
        }

        public override double Brobizz()
        {
            var brobizzpris = Pris() * StandardRabat();
            return brobizzpris;
        }
    }
}