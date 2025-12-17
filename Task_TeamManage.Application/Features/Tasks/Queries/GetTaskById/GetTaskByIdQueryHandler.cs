using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Application.DTOs.Tasks;
using Task_TeamManage.Application.Interfaces;
using Task_TeamManage.Domain.Entities;

namespace Task_TeamManage.Application.Features.Tasks.Queries.GetTaskById
{
    public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, TaskDto>
    {
        private readonly IGenericRepository<TaskItem> _repository;
        private readonly IMapper _mapper;

        public GetTaskByIdQueryHandler(IGenericRepository<TaskItem> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TaskDto> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var task = await _repository.GetByIdAsync(request.Id);
            return task == null ? null : _mapper.Map<TaskDto>(task);
        }
    }
}
