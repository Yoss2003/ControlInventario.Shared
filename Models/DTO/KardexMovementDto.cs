using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ControlInventario.Shared.Models.DTO
{
    public class KardexMovementDto
    {
        public int Id { get; set; }
        public int ActionId { get; set; }
        public string MovementDate { get; set; } = string.Empty;
        public string Observation { get; set; } = string.Empty;
        public string Recipient { get; set; } = string.Empty;
        public bool HasRecipient => !string.IsNullOrWhiteSpace(Recipient);
        public double Amount { get; set; }
        public double SalePrice { get; set; }
        public double TotalValue => Amount * SalePrice;
        public string AmountDisplay => ActionId == 1 ? $"+{Amount} un." : (ActionId == 2 ? $"-{Amount} un." : $"{Amount} un.");
        public double RunningBalance { get; set; }
    }

    public class ProductKardexGroup : INotifyPropertyChanged
    {
        public int ArticleId { get; set; }
        public string ArticleName { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public decimal CurrentStock { get; set; }

        public List<KardexMovementDto> AllMovements { get; set; } = new();

        private bool _isExpanded;
        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                _isExpanded = value;
                OnPropertyChanged(nameof(IsExpanded));
                OnPropertyChanged(nameof(ExpansionIcon));
            }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }

        public string ExpansionIcon => IsExpanded ? "🔼" : "🔽";

        public ProductKardexGroup(string articleName, string sku, decimal currentStock, IEnumerable<KardexMovementDto> movements)
        {
            ArticleName = articleName;
            Sku = sku;
            CurrentStock = currentStock;
            AllMovements = new List<KardexMovementDto>(movements);
            IsExpanded = false;
        }

        public void ToggleExpansion()
        {
            IsExpanded = !IsExpanded;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
