using InterfaceConcepts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcepts.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService) 
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double parceValuelQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i ++)
            {
                double quotaWithInterestTax = parceValuelQuota + _onlinePaymentService.Interest(parceValuelQuota, i);
                double quotaWithPaymentFree = quotaWithInterestTax + _onlinePaymentService.PaymentFree(quotaWithInterestTax);

                contract.AddInstallment(new Installment(quotaWithPaymentFree, contract.Date.AddMonths(i)));
            }
        }
    }
}
