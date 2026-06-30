using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; // 🌟 1. Agrega esto arriba

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

        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime SaleDate { get; set; }
        public PaymentType PaymentType { get; set; }
        public int SalesModeId { get; set; }
        public SalesMode? SalesMode { get; set; }
        public string? CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Notes { get; set; }
        public List<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
    }
}