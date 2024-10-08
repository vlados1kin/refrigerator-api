﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refrigerator.Domain.Entities;

public class Product
{
    [Column("ProductId")] 
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int DefaultQuantity { get; set; }
    
    public virtual ICollection<FridgeProduct>? FridgeProducts { get; set; }
}