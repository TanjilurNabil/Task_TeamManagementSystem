using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TeamManage.Application.Interfaces;
using Task_TeamManage.Domain.Entities;

namespace Task_TeamManage.Application.Features.Tasks.Commands.CreateTask
{
    public class CreateTaskCommandValidator:AbstractValidator<CreateTaskCommand>
    {
        private readonly IGenericRepository<TaskItem> _repository;

        public CreateTaskCommandValidator(IGenericRepository<TaskItem> repository)
        {
            _repository = repository;
            RuleFor(x => x.Title)
                .NotEmpty()
                
                .WithMessage("Title is required!");
            RuleFor(x => x.Description)
                .NotEmpty()
                .MinimumLength(4)
                .WithMessage("Describe a little about the task");
        }
    }
}
