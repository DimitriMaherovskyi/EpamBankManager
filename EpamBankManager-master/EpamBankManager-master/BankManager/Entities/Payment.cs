// Review DM: Unused not deleted.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payment
    {
        #region Public properties
        public int Id { get; set; }

        public int CreditId { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public int UserId { get; set; }
        #endregion
    }
}
