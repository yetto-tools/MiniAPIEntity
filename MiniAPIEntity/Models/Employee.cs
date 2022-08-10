using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiniAPIEntity.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }


    }
}
