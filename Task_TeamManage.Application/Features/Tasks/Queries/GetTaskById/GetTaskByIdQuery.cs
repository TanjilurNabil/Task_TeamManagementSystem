using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Application.DTOs.Tasks;

namespace Task_TeamManage.Application.Features.Tasks.Queries.GetTaskById
{
    public record GetTaskByIdQuery(Guid Id):IRequest<TaskDto>;
    
}
