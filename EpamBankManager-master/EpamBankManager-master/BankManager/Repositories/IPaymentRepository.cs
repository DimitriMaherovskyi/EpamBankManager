// Review DM: Unused are not removed.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> GetPayments();

        IEnumerable<Payment> GetPayments(int creditId);

        int PassPayment(Payment newPayment);
    }
}
