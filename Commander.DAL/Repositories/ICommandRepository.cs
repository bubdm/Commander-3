using System.Collections.Generic;
using Commander.DAL.Models;

namespace Commander.DAL.Repositories
{
    public interface ICommandRepository
    {
        IEnumerable<Command> GetAll();
        Command GetById(int id);
    }
}