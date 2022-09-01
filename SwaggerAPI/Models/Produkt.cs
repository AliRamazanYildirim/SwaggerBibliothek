using System;
using System.Collections.Generic;

namespace SwaggerAPI.Models
{
    public partial class Produkt
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Preis { get; set; }
        public DateTime? Datum { get; set; }
        public string? Kategorie { get; set; }
    }
}
