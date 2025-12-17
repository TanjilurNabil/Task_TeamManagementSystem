using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Application.DTOs.Tasks;
using Task_TeamManage.Application.Features.Tasks.Commands.CreateTask;
using Task_TeamManage.Application.Interfaces;
using Task_TeamManage.Domain.Entities;

namespace Task_TeamManage.Application.Features.Tasks.Commands.CreateTask
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, TaskDto>
    {
        private readonly IGenericRepository<TaskItem> _repository;
        private readonly IMapper _mapper;

        public CreateTaskCommandHandler(IGenericRepository<TaskItem> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TaskDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var taskDomainModel = _mapper.Map<TaskItem>(request);
            await _repository.AddAsync(taskDomainModel);
            await _repository.SaveChangesAsync();
            return _mapper.Map<TaskDto>(taskDomainModel);
        }
    }
}
