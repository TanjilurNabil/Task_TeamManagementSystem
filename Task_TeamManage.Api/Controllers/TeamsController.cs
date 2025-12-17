using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_TeamManage.Application.DTOs;
using Task_TeamManage.Application.Features.Teams.Commands;
using Task_TeamManage.Application.Features.Teams.Commands.DeleteTeam;
using Task_TeamManage.Application.Features.Teams.Commands.UpdateTeam;
using Task_TeamManage.Application.Features.Teams.Queries.GetAllTeam;
using Task_TeamManage.Application.Features.Teams.Queries.GetTeamById;

namespace Task_TeamManage.Api.Controllers
{
    
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ILogger<TeamsController> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly IValidator<TeamAddCommand> _validator;

        public TeamsController(ILogger<TeamsController> logger,
            IMapper mapper, IMediator mediator,IValidator<TeamAddCommand> validator)
        {
            _logger = logger;
            _mapper = mapper;
            _mediator = mediator;
            _validator = validator;
        }

        [HttpPost(ApiEndpoints.Teams.Create)]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] TeamAddCommand command)
        {
            var validate = await _validator.ValidateAsync(command);
            if (!validate.IsValid)
            {
                return BadRequest(validate.ToDictionary());
            }
            var createdTeam = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTeamById), new { id = createdTeam.Id }, createdTeam);
        }
        [HttpGet(ApiEndpoints.Teams.Get)]
        public async Task<IActionResult> GetTeamById(Guid id)
        {
            var team = await _mediator.Send(new GetTeamByIdQuery(id));
            return Ok(team);
        }
        [HttpGet(ApiEndpoints.Teams.GetAll)]
        public async Task<ActionResult<IEnumerable<TeamDto>>> GetAll()
        {
            var teams = await _mediator.Send(new GetAllTeamQuery());
            return Ok(teams);
        }

        [HttpPut(ApiEndpoints.Teams.Update)]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<TeamDto>> Update([FromRoute] Guid id, [FromBody] UpdateTeamDto request)
        {
            var command = new UpdateTeamCommand(
                           Id: id,
                         Name: request.Name,
                         Description: request.Description
                );

            if (id != command.Id)
                return BadRequest(new { message = "Route Id and body Id do not match" });
            var updatedTeam = await _mediator.Send(command);
            if (updatedTeam == null)
                return NotFound(new { message = $"Team with Id {id} not found" });
            return Ok(updatedTeam);
        }

        [HttpDelete(ApiEndpoints.Teams.Delete)]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _mediator.Send(new DeleteTeamCommand(id));
            if (!result)
                return NotFound(new { message = $"Team with Id {id} not found" });

            return NoContent();
        }
    }
}
