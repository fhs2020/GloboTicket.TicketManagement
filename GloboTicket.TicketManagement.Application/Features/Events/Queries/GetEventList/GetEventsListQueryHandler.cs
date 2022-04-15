using AutoMapper;

using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;

using MediatR;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Events
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventListQuery, List<EventListVM>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> evenRepository)
        {
            _mapper = mapper;
            _eventRepository = evenRepository;
        }

        public async Task<List<EventListVM>> Handle(GetEventListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListVM>>(allEvents);
        }
    }
}