using Microsoft.EntityFrameworkCore;
using MudblazorDemo.CRUD.Data;
using MudblazorDemo.CRUD.DbContexts;
using System.Collections.Generic;
using System.Linq;

namespace MudblazorDemo.CRUD.Services
{
    public interface ICityService
    {
        List<City> GetCities();
    }

    public class CityService : ICityService
    {
        private readonly ApplicationDbContext _context;

        public CityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<City> GetCities()
        {
            return _context.Cities.Include(c => c.State).ToList();
        }
    }

}
