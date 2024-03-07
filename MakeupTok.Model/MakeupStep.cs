using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupTok.Model;

public class MakeupStep
{

    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [MinLength(5)]
    public string Name { get; set; }

    [Required]
    [MaxLength(500)]
    [MinLength(5)]
    public string Description { get; set; }

    [Required]
    public string Color { get; set; }

    public Makeup Makeup { get; set; }

}
