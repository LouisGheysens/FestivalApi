using Business.Service;
using Dto.Model;
using Gridify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface;
public interface ITicketService
{
    Task<ServiceResponse<List<TicketDto>>> GetTicketsAsync(GridifyQuery gQuery, CancellationToken token);
    Task<ServiceResponse<TicketDto>> GetTicketAsync(int id, CancellationToken token);
    Task<ServiceResponse<int>> CreateTicketAsync(TicketDto dto, CancellationToken token);
    Task<ServiceResponse<int>> UpdateTicketAsync(int id, TicketDto dto, CancellationToken token);
    Task<ServiceResponse<object>> DeleteTicketAsync(int id, CancellationToken token);
}
