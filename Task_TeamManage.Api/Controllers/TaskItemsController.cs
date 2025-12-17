using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Security.Claims;
using Task_TeamManage.Application.DTOs.Tasks;
using Task_TeamManage.Application.Features.Tasks.Commands.CreateTask;
using Task_TeamManage.Application.Features.Tasks.Commands.UpdateTaskStatus;
using Task_TeamManage.Application.Features.Tasks.Queries.GetTaskById;

namespace Task_TeamManage.Api.Controllers
{
    
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        private readonly ILogger<TaskItemsController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IValidator<CreateTaskCommand> _validator;

        public TaskItemsController(ILogger<TaskItemsController> logger,
           IMediator mediator, IMapper mapper, IValidator<CreateTaskCommand> validator )
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
            _validator = validator;
        }

        [HttpPost(ApiEndpoints.Tasks.Create)]
        [Authorize(Roles ="Manager")]
        public async Task<IActionResult> Create([FromBody] CreateTaskCommand command)
        {
            var validate = await _validator.ValidateAsync(command);
            if (!validate.IsValid)
            {
                return BadRequest(validate.ToDictionary());
            }
            
   
            var createdTask = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTaskById), new { id = createdTask.Id }, createdTask);
        }

        [HttpGet(ApiEndpoints.Tasks.Get)]
        public async Task<IActionResult> GetTaskById(Guid id)
        {
            var task = await _mediator.Send(new GetTaskByIdQuery(id));
            return Ok(task);
        }

        [HttpPut(ApiEndpoints.Tasks.Update)]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> UpdateStatus(Guid id, TaskStatus status)
        {
            var success = await _mediator.Send(new UpdateTaskStatusCommand(id, status));
            return success ? NoContent() : NotFound();
        }
    }
}
