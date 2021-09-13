using System.Collections.Generic;
using Commander.DAL.Models;

namespace Commander.DAL.Repositories
{
    public class CommandRepository : ICommandRepository
    {
        public IEnumerable<Command> GetAll()
        {
            var commands = new List<Command>
            {
                new Command() {Id = 1, Line = "first line", HowTo = "once", Platform = "any platform"},
                new Command() {Id = 2, Line = "second line", HowTo = "twice", Platform = "any platform"},
                new Command() {Id = 3, Line = "third line", HowTo = "triple", Platform = "any platform"}
            };
            return commands;
        }

        public Command GetById(int id)
        {
            return new Command()
            {
                Id = 1,
                Line = "any string",
                HowTo = "any advice",
                Platform = "any platform"
            };
        }
    }
}