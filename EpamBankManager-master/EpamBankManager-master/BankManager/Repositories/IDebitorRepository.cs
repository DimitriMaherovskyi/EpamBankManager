// Review DM: Unused are not removed.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories
{
    public interface IDebitorRepository
    {
        IEnumerable<Debitor> GetDebitors(string name, string lastName, string address, string phone);

        IEnumerable<Debitor> GetDebitors();

        int AddDebitor(Debitor newDebitor);
    }
}
