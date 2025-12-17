using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Application.Interfaces;
using Task_TeamManage.Domain.Entities;

namespace Task_TeamManage.Application.Features.Tasks.Commands.UpdateTaskStatus
{
    public class UpdateTaskStatusCommandHandler :
    IRequestHandler<UpdateTaskStatusCommand, bool>
    {
        private readonly IGenericRepository<TaskItem> _repository;

        public UpdateTaskStatusCommandHandler(IGenericRepository<TaskItem> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(UpdateTaskStatusCommand request, CancellationToken cancellationToken)
        {
            var task = await _repository.GetByIdAsync(request.Id);
            if (task == null) return false;

            task.Status = request.Status;
            _repository.Update(task);
            await _repository.SaveChangesAsync();

            return true;
        }
    }

}
