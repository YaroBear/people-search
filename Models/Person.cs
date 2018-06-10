using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleSearch.Models
{
    [Table("People")]
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        
        public List<Interest> Interests { get; set; }

        public int PictureId { get; set; }

        public Picture Picture { get; set; }

        public Person()
        {
            Interests = new List<Interest>();
        }


    }
}