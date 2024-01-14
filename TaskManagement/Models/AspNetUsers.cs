using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class AspNetUsers
    {
        [Key]
        public string Id { get; set; }
        public string UserName { get; set; }
    }
}
