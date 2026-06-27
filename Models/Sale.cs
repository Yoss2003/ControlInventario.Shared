using System;
using System.Collections.Generic;

namespace ControlInventario.Shared.Models
{
    public enum PaymentType
    {
        Efectivo,
        Tarjeta,
        Yape,
        Plin,
        Bim,
        Transferencia,
        Cuotas
    }

    public class Sale
    {
        public int Id { get; set; }

        // Relación con el empleado que realizó la venta
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime SaleDate { get; set; }
        public PaymentType SelectedPaymentType { get; set; }
        public int SalesModeId { get; set; }
        public SalesMode? SalesMode { get; set; }

        public decimal TotalAmount { get; set; }
        public string? Notes { get; set; }

        // Relación con los productos que van dentro de este ticket
        public List<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
    }
}