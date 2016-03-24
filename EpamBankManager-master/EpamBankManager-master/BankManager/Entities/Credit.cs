// Review DM: Unused not deleted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Credit
    {
        #region Public properties
        public int Id { get; set; }

        public int DebitorId { get; set; }

        public DateTime OpenDate { get; set; }

        public decimal Amount { get; set; }

        public decimal Balance { get; set; }

        public int TypeId { get; set; }

        public string State { get; set; }

        public int UserId { get; set; }
        #endregion
    }
}
