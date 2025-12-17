using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_TeamManage.Application.Features.Tasks.Commands.UpdateTaskStatus
{
    public record UpdateTaskStatusCommand(Guid Id, TaskStatus Status) : IRequest<bool>;
}
