using BusTicket.DataAccess.Infrastructure;
using BusTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Reprositories
{
    public class SeatRepository : GenericRepository<SeatDetail>, ISeatRepository
    {
        private readonly ApplicationDbContext _context;
        public SeatRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void update(SeatDetail seat)
        {
            var SeatfromDb = _context.SeatDetail.FirstOrDefault(x => x.Id == seat.Id);
            if (SeatfromDb != null)
            {
                SeatfromDb.SeatNo = seat.SeatNo;
                SeatfromDb.BusId = seat.BusId;
                SeatfromDb.Description = seat.Description;
            }
        }
    }
}
