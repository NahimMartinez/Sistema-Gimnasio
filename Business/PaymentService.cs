using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Business
{
    public class PaymentService
    {
        private readonly PaymentRepository paymentRepository = new PaymentRepository();
        
        public List<PaymentMethod> GetPaymentMethods()
        {
            return paymentRepository.GetPaymentMethods();
        }
    }
}
