using System.Collections.Generic;
using System.Linq;
using Commander.DAL.Models;

namespace Commander.DAL.Repositories
{
    public class CommandRepository : ICommandRepository
    {
        private readonly CommanderContext _context;

        public CommandRepository(CommanderContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Command> GetAll()
        {
            // это было до подключения к серверу БД
            /*
            var commands = new List<Command>
            {
                new Command() {Id = 1, Line = "first line", HowTo = "once", Platform = "any platform"},
                new Command() {Id = 2, Line = "second line", HowTo = "twice", Platform = "any platform"},
                new Command() {Id = 3, Line = "third line", HowTo = "triple", Platform = "any platform"}
            };
            return commands;
            */
            
            // стало обращение к таблице через контекст
            return _context.Commands.ToList();
        }

        public Command GetById(int id)
        {
            /*
            return new Command()
            {
                Id = 1,
                Line = "any string",
                HowTo = "any advice",
                Platform = "any platform"
            };
            */

            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}