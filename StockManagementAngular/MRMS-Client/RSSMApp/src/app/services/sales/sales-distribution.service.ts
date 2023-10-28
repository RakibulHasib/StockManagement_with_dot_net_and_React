import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../../models/Product/product';
import { SalesDistribution } from '../../models/sales/sales-distribution';
import { IceCreamApiUrl } from '../../models/shared/app-constants';
import { DailyDistributionModel } from 'src/app/models/DailyDataModel/daily-distribution-model';


  const endPoint: string = "SalesDistribute";

@Injectable({
  providedIn: 'root'
})
export class SalesDistributionService {

  constructor(
    private http: HttpClient
  ) { }

  getSalesDistributeDataPerDay(startDate: string, endDate: string): Observable<DailyDistributionModel[]> {
   return this.http.get<DailyDistributionModel[]>(`${IceCreamApiUrl}/${endPoint}/GetSalesDistributeDataPerDay?StartDate=${startDate}&EndDate=${endDate}`);
  }
  //getReportData(stockID: number): Observable<stockReportDataModel> {
  //  return this.http.get<stockReportDataModel>(`${IceCreamApiUrl}/${endPoint}/GetReport?StockId=${stockID}`);
  //}
  getPrice(productID: number): Observable<{ price: number }> {
    return this.http.get<{ price: number }>(`${IceCreamApiUrl}/${endPoint}/GetProductWisePrice?ProductID=${productID}`);
  }
  getProduct(): Observable<Product[]> {
    return this.http.get<Product[]>(`${IceCreamApiUrl}/${endPoint}/GetProduct`);
  }
  insert(data: {concernPerson: string, salesDistribute: SalesDistribution[]}): Observable<any> {
    return this.http.post<SalesDistribution[]>(`${IceCreamApiUrl}/${endPoint}/InsertSalesDistributeData`, data);
  }
}
