using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativodeContratoPaypal.Services
{
    internal class PaypalServices : IOnlinePaymentService
    {
        private const double FeePorcentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * FeePorcentage * months;
        }
        public double PaymentFee(double amount)
        {
            return amount * FeePorcentage;
        }
    }
}
