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

namespace Task_TeamManage.Application.Features.Teams.Commands.UpdateTeam
{
    public class UpdateTeamCommandHandler(IMapper mapper,IGenericRepository<Team> repository) : IRequestHandler<UpdateTeamCommand, TeamDto>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IGenericRepository<Team> _repository = repository;

        public async Task<TeamDto> Handle(UpdateTeamCommand request, CancellationToken cancellationToken)
        {
            var team = await _repository.GetByIdAsync(request.Id);
            if (team == null) return null;

            team.Name = request.Name;
            team.Description = request.Description;
            _repository.Update(team);
            await _repository.SaveChangesAsync();
            return _mapper.Map<TeamDto>(team);
        }
    }
}
