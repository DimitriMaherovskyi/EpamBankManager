// Review DM: Unused not deleted.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Debitor
    {
        #region Public properties
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public int UserId { get; set; }
        #endregion
    }
}
