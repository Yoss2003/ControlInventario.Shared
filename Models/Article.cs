using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlInventario.Shared.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int InventoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; } = string.Empty;

        [StringLength(150)]
        public string? Barcode { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(150)]
        public string Model { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int BrandId { get; set; }
        public int? SupplierId { get; set; }

        [Required]
        public TrackingMode Tracking { get; set; }

        [Required]
        [StringLength(50)]
        public string MeasurementUnit { get; set; } = "Unidades";

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Stock { get; set; }

        [StringLength(150)]
        public string? SerialNumber { get; set; }

        // Control de Custodia y Responsables (Nacen en null para administración del encargado)
        public int? CurrentEmployeeId { get; set; }
        public int? PreviousEmployeeId { get; set; }

        [StringLength(100)]
        public string? FixedAsset { get; set; }

        // Información Financiera y Monedas Multiambiente
        [Column(TypeName = "decimal(18,2)")]
        public decimal? AcquisitionPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? SalePrice { get; set; }

        [StringLength(10)]
        public string? AcquisitionCurrency { get; set; }

        public DateTime? AcquisitionDate { get; set; }

        // Historial de Estados y Fechas de Procesos (Nacen en null para flujos futuros)
        public DateTime? DecommissionDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        // Parámetros de Activo Fijo (Obligatorio estrictamente en Serialized)
        public int? UsefulLifeMonths { get; set; }
        public DateTime? WarrantyEndDate { get; set; }

        public string? Characteristics { get; set; }
        public string? Observation { get; set; }

        //SOLUCIÓN AL ERROR 500: Ahora son nulables (int?) para evitar el envío involuntario de ceros '0'
        public int? StatusId { get; set; }
        public int? LocationId { get; set; }
        public int? ConditionId { get; set; }

        // Evidencias Digitales en la Nube (Limpios de segundarias locales obsoletas)
        public string? MainPhotoPath { get; set; }
        public string? MainVoucherPath { get; set; }

        // Auditoría Básica del Primer Movimiento
        [Required]
        public int ActionId { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}