using System.ComponentModel.DataAnnotations;

namespace ControlInventario.Shared.Models
{
    public class ArticleDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ArticleId { get; set; }

        // Corresponde a Label1 (Ej: "8GB")
        public string? Value1 { get; set; }

        // Corresponde a Label2 (Ej: "256GB")
        public string? Value2 { get; set; }

        // Corresponde a Label3 (Ej: "Negro")
        public string? Value3 { get; set; }

        public string? Value4 { get; set; }
        public string? Value5 { get; set; }

        // Espacio de contingencia (dejamos hasta 10 como sugeriste por si acaso en el futuro)
        public string? Value6 { get; set; }
        public string? Value7 { get; set; }
        public string? Value8 { get; set; }
        public string? Value9 { get; set; }
        public string? Value10 { get; set; }
    }
}