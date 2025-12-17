using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Application.DTOs.Tasks;

namespace Task_TeamManage.Application.Features.Tasks.Commands.CreateTask
{
    public record CreateTaskCommand(
        string Title,
        string? Description,
        string TeamId,
        string? AssignedToUserId,
        DateTime? DueDate,
        string CreatedByUserId
        ): IRequest<TaskDto>;
}
