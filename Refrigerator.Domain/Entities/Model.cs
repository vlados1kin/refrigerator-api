﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class Model
{
    [Column("ModelId")]
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int Year { get; set; }
    
    public Guid FridgeId { get; set; }
    public Fridge? Fridge { get; set; }
}