using BusTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Infrastructure
{
    public interface IBusRepository:IGenericRepository<Bus>
    {
        void update(Bus bus);
    }
}
