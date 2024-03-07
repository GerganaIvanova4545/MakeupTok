using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupTok.Model;

[Table("Makeups")]
public class Makeup
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
    public string Image { get; set; }

    public IEnumerable<MakeupStep> Steps { get; set; }

    public User User { get; set; }

}
