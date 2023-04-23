using BusTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Infrastructure
{
    public interface ISeatRepository:IGenericRepository<SeatDetail>
    {
        void update(SeatDetail seat);
    }
}
