using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcepts.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFree(double amount);
        double Interest(double amount, int months);
    }
}
