﻿namespace StockManagement.DTO
{
    public class SalesDistributeDTO
    {

        public string? ConcernPerson { get; set; }
        public Guid SalesDistributeDetailsId { get; set; }
        public long SalesDistributeId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int ReceiveQuantity { get; set; }
        public int ReturnQuantity { get; set; }
        public int SalesQuantity { get; set; }
        public decimal TotalSalesPrice { get; set; }
        public DateTime CreationTime { get; set; }
        public int IsDeleted { get; set; }
    }
}