using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Application.DTOs;
using Task_TeamManage.Application.Interfaces;
using Task_TeamManage.Domain.Entities;

namespace Task_TeamManage.Application.Features.Teams.Queries.GetTeamById
{
    public class GetTeamByIdQueryHandler : IRequestHandler<GetTeamByIdQuery, TeamDto>
    {
        private readonly IGenericRepository<Team> _repository;
        private readonly IMapper _mapper;

        public GetTeamByIdQueryHandler(IGenericRepository<Team> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TeamDto> Handle(GetTeamByIdQuery request, CancellationToken cancellationToken)
        {
            var team =  await _repository.GetByIdAsync(request.Id);
            if (team == null) return null;
            return _mapper.Map<TeamDto>(team);
        }
    }
}
