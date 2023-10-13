﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockManagement.DTO;
using StockManagement.Entities;
using StockManagement.Repository;

namespace StockManagement.Services;

public class StockService
{
    private readonly UnitOfWork _unitOfWork;

    public StockService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<ActionResult<IEnumerable<DailyDataDTO>>> GetStockDataPerDay(int companyId, DateTime StartDate, DateTime EndDate)
    {
        var query = await _unitOfWork.Stock.Queryable
                    .Where(x => x.CreationTime.Date >= StartDate.Date && x.CreationTime.Date <= EndDate.Date
                            && x.CompanyId == companyId)
                    .Select(query => new DailyDataDTO
                    {
                        StockId = query.StockId,
                        CreationTime = query.CreationTime,
                        TotalSalesQuantity = query.TotalSalesQuantity,
                        TotalAmount = query.GrandTotalAmount
                    }).ToListAsync();
        return query;
    }


    public async Task<ActionResult<int>> InsertStockData(int companyId, List<StockDTO> savoyIceCreamVM)
    {
        int result = 0;
        Stock master = new Stock
        {
            CompanyId = companyId,
            TotalEja = 0,
            TotalPrice = 0,
            TotalNewProduct = 0,
            GrandTotal = 0,
            TotalSalesQuantity = 0,
            GrandTotalAmount = 0,
            TotalDumping = 0,
            TotalReceive = 0,
            TotalRemaining = 0,
        };
        await _unitOfWork.Stock.AddAsync(master);
        await _unitOfWork.SaveChangesAsync();

        foreach (var item in savoyIceCreamVM)
        {
            var total = (item.Eja ?? 0) + (item.NewProduct);
            var stockDetails = new StockDetail
            {
                StockId = master.StockId,
                CompanyId = companyId,
                ProductId = item.ProductId,
                Price = item.Price,
                RestockQuantity = item.NewProduct,
                TotalQuantity = total,
                Eja = total - (item.SalesQuantity ?? 0),
                SalesQuantity = item.SalesQuantity,
                TotalAmount = (item.SalesQuantity) * (item.Price),
                Dumping = item.Dumping,
                Receive = item.Receive,
                Remaining = (item.Dumping ?? 0) - (item.Receive ?? 0),
            };
            await _unitOfWork.StockDetail.AddAsync(stockDetails);
        }
        await _unitOfWork.SaveChangesAsync();

        master.TotalEja = await _unitOfWork.StockDetail.Queryable.Where(a => a.StockId == master.StockId).SumAsync(a => a.Eja ?? 0);
        master.TotalPrice = await _unitOfWork.StockDetail.Queryable.Where(a => a.StockId == master.StockId).SumAsync(a => a.Price);
        master.TotalNewProduct = await _unitOfWork.StockDetail.Queryable.Where(a => a.StockId == master.StockId).SumAsync(a => a.RestockQuantity ?? 0);
        master.GrandTotal = await _unitOfWork.StockDetail.Queryable.Where(a => a.StockId == master.StockId).SumAsync(a => a.TotalQuantity ?? 0);
        master.TotalSalesQuantity = await _unitOfWork.StockDetail.Queryable.Where(a => a.StockId == master.StockId).SumAsync(a => a.SalesQuantity ?? 0);
        master.GrandTotalAmount = await _unitOfWork.StockDetail.Queryable.Where(a => a.StockId == master.StockId).SumAsync(a => a.TotalAmount ?? 0);
        master.TotalDumping = await _unitOfWork.StockDetail.Queryable.Where(a => a.StockId == master.StockId).SumAsync(a => a.Dumping ?? 0);
        master.TotalReceive = await _unitOfWork.StockDetail.Queryable.Where(a => a.StockId == master.StockId).SumAsync(a => a.Receive ?? 0);
        master.TotalRemaining = await _unitOfWork.StockDetail.Queryable.Where(a => a.StockId == master.StockId).SumAsync(a => a.Remaining ?? 0);

        _unitOfWork.Stock.Update(master);
        result = await _unitOfWork.SaveChangesAsync();
        return result;
    }

    //public async Task<ActionResult<IEnumerable<SavoyReportDTO>>> GetSavoyReport(int SavoyIceCreamMasterId)
    //{
    //    var savoyIceCreamData = await _unitOfWork.Stock.Queryable
    //        .Where(a => a.StockId == SavoyIceCreamMasterId)
    //        .ToListAsync();

    //    var productData = await _unitOfWork.Product.Queryable.ToListAsync();

    //    var joinedData = from si in savoyIceCreamData
    //                     join p in productData on si.ProductId equals p.ProductId
    //                     select new SavoyReportDTO
    //                     {
    //                         SavoyIceCreamMasterId = si.SavoyIceCreamMasterId,
    //                         SavoyIceCreamId = si.SavoyIceCreamId,
    //                         CompanyId = si.CompanyId,
    //                         ProductId = si.ProductId,
    //                         ProductName = p.ProductName,
    //                         Eja = si.Eja,
    //                         Price = si.Price,
    //                         NewProduct = si.NewProduct,
    //                         Total = si.Total,
    //                         SalesQuantity = si.SalesQuantity,
    //                         TotalAmount = si.TotalAmount,
    //                         Dumping = si.Dumping,
    //                         Receive = si.Receive,
    //                         Remaining = si.Remaining,
    //                         CreatedDate = si.CreatedDate
    //                     };

    //    return joinedData.ToList();
    //}


}
