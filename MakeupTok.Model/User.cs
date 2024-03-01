﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupTok.Model;

public class User
{

    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    [MinLength(5)]
    public string Username { get; set; }

    [Required]
    [MaxLength(30)]
    [MinLength(5)]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    public string ProfileImage { get; set; }

    public IEnumerable<Makeup> Makeups { get; set; }

}
