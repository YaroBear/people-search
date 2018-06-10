using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleSearch.Models
{
    [Table("Pictures")]
    public class Picture
    {
        public int Id { get; set; }
        public string FileName { get; set; }
    }
}