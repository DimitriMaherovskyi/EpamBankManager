// Review DM: Unused are not removed.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    interface ITypeOfCreditRepository
    {
        IEnumerable<TypeOfCredit> GetTypes();
    }
}
