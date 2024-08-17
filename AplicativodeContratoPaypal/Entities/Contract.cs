using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AplicativodeContratoPaypal.Entities
{
    internal class Contract
    {
        public  int Number { get; set; }
        public DateTime Date { get; set; }
        public double  totalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            this.totalValue = totalValue;
            Installments = new List<Installment>();
        }
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

    }
}
