﻿using System;

namespace BilletLibrary
{
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Date { get; set; }


        /// <summary>
        /// En metode som retuner prisen som decimal.
        /// </summary>
        /// <returns></returns>
        public decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// En metode som retunere hvilket køretøj det er (Bil).
        /// </summary>
        /// <returns></returns>
        public string Køretøj()
        {
            return "Bil";
        }
    }
}
