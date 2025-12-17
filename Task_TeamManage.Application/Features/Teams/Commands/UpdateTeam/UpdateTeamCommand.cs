using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Application.DTOs;

namespace Task_TeamManage.Application.Features.Teams.Commands.UpdateTeam
{
    public record UpdateTeamCommand(Guid Id, string Name,string? Description):IRequest<TeamDto>;

    
}
