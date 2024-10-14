using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.collections
{
    public class PaymentService
    {
        private List<Payment> payments = new List<Payment>();

        public void AddPayment(Payment payment)
        {
            payments.Add(payment);
        }

        public void UpdatePaymentStatus(int paymentId, string status)
        {
            var payment = payments.FirstOrDefault(p => p.PaymentID == paymentId);
            if (payment == null)
            {
                throw new InvalidDataException("Payment not found.");
            }
            payment.Status = status;
        }
    }

}
