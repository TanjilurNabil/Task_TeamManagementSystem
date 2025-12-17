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

namespace Task_TeamManage.Application.Features.Teams.Commands
{
    public class TeamAddHandler : IRequestHandler<TeamAddCommand, TeamDto>
    {
        private readonly IGenericRepository<Team> _repository;
        private readonly IMapper _mapper;

        public TeamAddHandler(IGenericRepository<Team> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TeamDto> Handle(TeamAddCommand request, CancellationToken cancellationToken)
        {
            var teamDomainModel= _mapper.Map<Team>(request);
            await _repository.AddAsync(teamDomainModel);
            await _repository.SaveChangesAsync();
            return _mapper.Map<TeamDto>(teamDomainModel);
        }
    }
}
