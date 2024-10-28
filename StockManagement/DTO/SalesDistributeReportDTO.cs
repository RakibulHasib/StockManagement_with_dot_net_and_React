namespace StockManagement.DTO
{
    public class SalesDistributeReportDTO
    {
        public long SalesDistributeId { get; set; }
        public string? ConcernPerson { get; set; }
        public string? CompanyName { get; set; }
        public DateTime CreationTime { get; set; }
        public decimal? DamageAmount { get; set; }
        public decimal? AfterDamagePrice { get; set; }
        public decimal? Srcommission { get; set; }
        public decimal? AfterSrCommission { get; set; }
        public decimal? Dsrcommission { get; set; }
        public decimal? AfterDsrCommission { get; set; }
        public List<SalesDistributeReportDetail>? reportDetails { get; set; }
    }

    public class SalesDistributeReportDetail
    {
        public Guid SalesDistributeDetailsId { get; set; }
        public long SalesDistributeId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
        public int ReceiveQuantity { get; set; }
        public decimal ReceivePrice { get; set; }
        public int ReturnQuantity { get; set; }
        public decimal ReturnPrice { get; set; }
        public int SalesQuantity { get; set; }
        public decimal TotalSalesPrice { get; set; }
        public int? DamageQuantity { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
