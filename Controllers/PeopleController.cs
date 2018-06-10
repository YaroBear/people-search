using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeopleSearch.Controllers.Resources;
using PeopleSearch.Models;
using PeopleSearch.Persistence;

namespace PeopleSearch.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleSearchDbContext context;
        private readonly IMapper mapper;
        public PeopleController(PeopleSearchDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }
        
        [HttpGet("/api/people")]
        public async Task<IEnumerable<PersonResource>> GetPeople()
        {
            var people =  await context.People.Include(m => m.Interests).Include(m => m.Picture).ToListAsync();

            return mapper.Map<List<Person>, List<PersonResource>>(people);
        }

        [HttpGet("/api/people/:query")]
        public async Task<IEnumerable<Person>> SearchPeople()
        {
            return await context.People.ToArrayAsync();
            // Include(m => m.Interests).Include(m => m.Picture).ToListAsync();
        }
    }
}