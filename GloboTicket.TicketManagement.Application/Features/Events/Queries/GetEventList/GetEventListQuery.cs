using MediatR;

using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.Events
{
    public class GetEventListQuery : IRequest<List<EventListVM>>
    {

    }
}
