using System.Collections.Generic;

namespace PeopleSearch.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        
        public List<Interest> Interests { get; set; }

        public int PictureId { get; set; }

        public Picture Picture { get; set; }


    }
}