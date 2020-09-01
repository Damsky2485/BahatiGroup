
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BahatiGroup.Web.Shared.Core.Interfaces
{
   public interface ITicketRepository
    {
        Task<Ticket> AddTicketAsync(Ticket ticket);
        Task<List<Ticket>> GetTicketsAsync();
        Ticket GetTicketById(int ticketId);
        Task<Ticket> UpdateTicketAsync(Ticket ticket);
         void DeleteTicket(int ticketId);
    }
}
