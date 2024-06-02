using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Model;

public class Entity
{
    [Key]

    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}

