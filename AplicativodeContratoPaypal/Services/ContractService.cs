using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicativodeContratoPaypal.Entities;

namespace AplicativodeContratoPaypal.Services
{
    internal class ContractService 
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void processContract(Contract contract, int months)
        {
            double basicQuota = contract.totalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddDays(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
