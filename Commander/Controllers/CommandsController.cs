using System.Collections.Generic;
using Commander.DAL.Models;
using Commander.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [ApiController]
    [Route("api/commands")]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepository _repository;

        public CommandsController(ICommandRepository repository)
        {
            _repository = repository;
        }
        
        // сначала было это, но его заменили на внедренную зависимость и проброс в конструкторе
        //private readonly CommandRepository _repository = new CommandRepository();
            
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAll();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetById(id);
            return Ok(commandItem);
        }
    }
}