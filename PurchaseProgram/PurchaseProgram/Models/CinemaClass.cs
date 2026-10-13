using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseProgram.Models
{
    class CinemaClass
    {
        private float pricePerTicket;
        private string[] nameCinema; // to-do: Реализовать список киношек

        public CinemaClass(float priceTicket, string[] nameCinema)
        {
            this.pricePerTicket = priceTicket;
            this.nameCinema = nameCinema;
        }

        public float GetPrice()
        {
            return this.pricePerTicket;
        }
    }
}
