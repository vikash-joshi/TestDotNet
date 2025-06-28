using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_PREP.Models
{
   public class Student
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Range(18, 100)]
    public int Age { get; set; }

    [EmailAddress]
    public string Email { get; set; }
}

}