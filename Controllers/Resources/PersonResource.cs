using System.Collections.Generic;
using System.Collections.ObjectModel;
using PeopleSearch.Models;

namespace PeopleSearch.Controllers.Resources
{
    public class PersonResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        
        public List<InterestResource> Interests { get; set; }

        public PictureResource Picture { get; set; }

        public PersonResource()
        {
            Interests = new List<InterestResource>();
        }
    }
}