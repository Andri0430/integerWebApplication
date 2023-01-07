using System.ComponentModel.DataAnnotations;

namespace integerWebApplication.Models
{
    public class Car
    {
        public int IdRegistration { get; set; }
        public string? Type { get; set; }
        public string? Brand { get; set; }
        public string? Variant { get; set; }
    }
}