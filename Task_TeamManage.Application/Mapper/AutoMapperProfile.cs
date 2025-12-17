using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Application.DTOs;
using Task_TeamManage.Application.DTOs.Tasks;
using Task_TeamManage.Application.DTOs.Users;
using Task_TeamManage.Application.Features.Tasks.Commands.CreateTask;
using Task_TeamManage.Application.Features.Teams.Commands;
using Task_TeamManage.Application.Features.Teams.Commands.UpdateTeam;
using Task_TeamManage.Domain.Entities;

namespace Task_TeamManage.Application.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TaskItem, TaskDto>().ReverseMap();
            CreateMap<CreateTaskCommand,TaskItem>().ReverseMap();
            CreateMap<Team, TeamDto>().ReverseMap();
            CreateMap<TeamAddCommand, Team>().ReverseMap();
            CreateMap<UpdateTeamDto, UpdateTeamCommand>().ReverseMap();
        }
    }
}
