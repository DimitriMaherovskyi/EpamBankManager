// Review DM:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TypeOfCredit
    {
        #region Public properties
        public int Id { get; set; }

        public string Type { get; set; }

        public int MaxTerm { get; set; }
        #endregion
    }
}
