using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpGet("/api/people/search")]
        [HttpGet("/api/people/search/{searchString}")]
        public async Task<IEnumerable<PersonResource>> SearchPeople(string searchString)
        {
            var people = await context.People.Include(m => m.Interests).Include(m => m.Picture).ToListAsync();
            
            if(!string.IsNullOrEmpty(searchString)){
                people = people.Where(p => p.Name.ToLower().Contains(searchString.ToLower())).ToList();
            }

            return mapper.Map<List<Person>, List<PersonResource>>(people);
        }

        [HttpGet("/api/people/slowSearch")]
        [HttpGet("/api/people/slowSearch/{searchString}")]
        public async Task<IEnumerable<PersonResource>> SlowSearchPeople(string searchString)
        {
            var people = await context.People.Include(m => m.Interests).Include(m => m.Picture).ToListAsync();
            
            if(!string.IsNullOrEmpty(searchString)){
                people = people.Where(p => p.Name.ToLower().Contains(searchString.ToLower())).ToList();
            }

            Task.Delay(2000).Wait();

            return mapper.Map<List<Person>, List<PersonResource>>(people);
        }
    }
}