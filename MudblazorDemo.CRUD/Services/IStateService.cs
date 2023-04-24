using MudblazorDemo.CRUD.Data;
using MudblazorDemo.CRUD.DbContexts;
using System.Collections.Generic;
using System.Linq;

namespace MudblazorDemo.CRUD.Services
{
    public interface IStateService
    {
        List<State> GetStates();
    }

    public class StateService : IStateService
    {
        private readonly ApplicationDbContext _context;

        public StateService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<State> GetStates()
        {
            return _context.States.ToList();
        }
    }

}
