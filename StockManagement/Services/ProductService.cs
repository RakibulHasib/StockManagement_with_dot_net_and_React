﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockManagement.Contexts;
using StockManagement.DTO;
using StockManagement.Entities;
using StockManagement.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StockManagement.Services;

public class ProductService
{
    private readonly UnitOfWork _unitOfWork;
    private readonly StockDBContext _db;

    public ProductService(UnitOfWork unitOfWork, StockDBContext db)
    {
        _unitOfWork = unitOfWork;
        _db = db;
    }

    public async Task<ActionResult<IEnumerable<GetProductData>>> GetProducCompanyWise(int CompanyId)
    {
        var products = await (from product in _unitOfWork.Product.Queryable
                              join company in _unitOfWork.Company.Queryable
                              on product.CompanyId equals company.CompanyId
                              where /*product.IsDeleted == 0 && product.IsActive == 1 &&*/ product.CompanyId == CompanyId
                              select new GetProductData
                              {
                                  ProductId = product.ProductId,
                                  ProductName = product.ProductName,
                                  Description = product.Description,
                                  Price = product.Price,
                                  CompanyId = product.CompanyId,
                                  CompanyName = company.CompanyName,
                                  IsActive = product.IsActive,
                                  IsDeleted = product.IsDeleted,
                                  Sequence = product.Sequence
                              }).ToListAsync();

        return products.ToList();
    }

    public async Task<ActionResult<ProductDTO>> GetProducByID(int ProductId)
    {
        var products = await (from product in _unitOfWork.Product.Queryable
                              where  product.ProductId == ProductId
                              select new ProductDTO
                              {
                                  ProductId = product.ProductId,
                                  ProductName = product.ProductName,
                                  Description = product.Description,
                                  Price = product.Price,
                                  CompanyId = product.CompanyId,
                                  IsActive = product.IsActive,
                                  IsDeleted = product.IsDeleted,
                                  Sequence = product.Sequence
                              }).FirstOrDefaultAsync();

        return products;
    }
    public async Task<ActionResult<int>> InsertProduct(ProductDTO product)
    {
        int result = 0;
        Product products = new Product
        {
            ProductName = product.ProductName,
            Description = product.Description,
            Price = product.Price,
            CompanyId = product.CompanyId,
            IsDeleted = 0,
            Sequence = product.Sequence,
            IsActive = product.IsActive,
        };
        await _unitOfWork.Product.AddAsync(products);

        result = await _unitOfWork.SaveChangesAsync();

        return result;
    }
    public async Task<ActionResult<int>> UpdateProduct(ProductDTO product)
    {
        int result = 0;
        Product products = new Product
        {
            ProductId = product.ProductId,
            ProductName = product.ProductName,
            Description = product.Description,
            Price = product.Price,
            CompanyId = product.CompanyId,
            IsDeleted = 0,
            Sequence = product.Sequence,
            IsActive = product.IsActive,
        };
         _unitOfWork.Product.Update(products);

        result = await _unitOfWork.SaveChangesAsync();

        return result;
    }


    public async Task<ActionResult<int>> DeleteProduct(int ProductId)
    {
        int result = 0;
        var data = await _db.Products.Where(a => a.ProductId == ProductId).FirstOrDefaultAsync();
        data.IsDeleted = 1;
        data.IsActive = 0;
        _unitOfWork.Product.Update(data);

        result = await _unitOfWork.SaveChangesAsync();

        return result;
    }
}