using BahatiGroup.Web.Shared.Core.Interfaces;
using BahatiGroup.Web.Shared.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BahatiGroup.Web.Shared.Core.Repositories
{
    public class TicketRepository : BaseRepository, ITicketRepository
    {
        public TicketRepository(BahatiDbContext _demoDbContext): base(_demoDbContext)
        {

        }
        public async Task<Ticket> AddTicketAsync(Ticket ticket)
        {
            try
            {
                var tick = await demoDbContext.Tickets.AddAsync(ticket);
                await demoDbContext.SaveChangesAsync();
                return tick.Entity;

                

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async void DeleteTicket(int ticketId)
        {
            try
            {
                var result = await demoDbContext.Tickets.FirstOrDefaultAsync(t => t.TicketId == ticketId);

                if(result != null)
                {
                    demoDbContext.Tickets.Remove(result);
                    await demoDbContext.SaveChangesAsync();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Ticket GetTicketById(int ticketId)
        {
            try
            {
              return demoDbContext.Tickets.FirstOrDefault(t => t.TicketId == ticketId);
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Ticket>> GetTicketsAsync()
        {
            try
            {
                var result = await demoDbContext.Tickets.ToListAsync();
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async  Task<Ticket> UpdateTicketAsync(Ticket ticket)
        {
            try
            {
                var result = await demoDbContext.Tickets.FirstOrDefaultAsync(t => t.TicketId == ticket.TicketId);

                if(result != null)
                {
                    result.Age = ticket.Age;
                    result.DateCreated = ticket.DateCreated;
                    result.SummaryDescription = ticket.SummaryDescription;
                    //to write more code here------
                    await demoDbContext.SaveChangesAsync();
                    return result;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
