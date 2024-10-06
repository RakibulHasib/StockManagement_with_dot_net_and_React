﻿using StockManagement.Attributes;
using StockManagement.Features.StockFeatures;
using StockManagement.Helpers;

namespace StockManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StockController : BaseController<StockController>
{
    private readonly StockService _stockService;

    public StockController(StockService stockService)
    {
        _stockService = stockService;
    }

    [Transaction]
    [HttpPost("InsertStockData/{companyId}")]
    public async Task<ActionResult<int>> InsertStockData([FromRoute] int companyId, DateTime createdDate, List<StockDTO> savoyIceCreamVM)
    {
        return Ok(await _stockService.InsertStockData(companyId, createdDate, savoyIceCreamVM));
    }

    [HttpGet("GetStockDataPerDay")]
    public async Task<ActionResult<IEnumerable<DailyDataDTO>>> GetStockDataPerDay([FromQuery] GetStockDataPerDayQuery query)
    {
        return await _mediator.Send(query);
    }

    [JwtAuthorize]
    [HttpGet("GetReport")]
    public async Task<ActionResult<ReportDTO>> GetReport(int StockId)
    {
        return await _stockService.GetReport(StockId);
    }

    [JwtAuthorize]
    [HttpPut("UpdateDamage")]
    public async Task<ActionResult<int>> UpdateDamageAmount(int StockId, decimal DamageAmount)
    {
        return Ok(await _stockService.UpdateDamageAmount(StockId, DamageAmount));
    }

    [JwtAuthorize]
    [HttpPut("UpdateSRCommission")]
    public async Task<ActionResult<int>> UpdateSRCommission(int StockId, decimal Commission)
    {
        return Ok(await _stockService.UpdateSRCommission(StockId, Commission));
    }

    [JwtAuthorize]
    [HttpGet("GetDamageAmountByID")]
    public async Task<ActionResult<decimal>> GetDamageAmountByID(int StockId)
    {
        return await _stockService.GetDamageAmountByID(StockId);
    }

    [JwtAuthorize]
    [HttpGet("GetCommissionByID")]
    public async Task<ActionResult<decimal>> GetCommissionByID(int StockId)
    {
        return await _stockService.GetCommissionByID(StockId);
    }

    [JwtAuthorize]
    [HttpGet("CheckCreatableStock")]
    public async Task<ActionResult<int>> CheckCreatableStock(int CompanyID)
    {
        return await _stockService.CheckCreatableStock(CompanyID);
    }
}
