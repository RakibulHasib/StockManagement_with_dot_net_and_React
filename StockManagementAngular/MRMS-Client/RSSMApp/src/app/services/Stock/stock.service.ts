import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Dailydatadbmodel } from '../../models/DailyDataModel/dailydatadbmodel';
import { IceCreamApiUrl } from '../../models/shared/app-constants';
import { Stock } from '../../models/Stock/Stock';
import { stockReportDataModel} from '../../models/Stock/stock-report';


const endPoint: string = "Stock";

@Injectable({
  providedIn: 'root'
})
export class StockService {

  constructor(
    private http: HttpClient
  ) { }

  getDashboardDataPerDay(companyId: number, startDate: string, endDate: string): Observable<Dailydatadbmodel[]> {
    return this.http.get<Dailydatadbmodel[]>(`${IceCreamApiUrl}/${endPoint}/GetStockDataPerDay?CompanyId=${companyId}&StartDate=${startDate}&EndDate=${endDate}`);
  }

  getReportData(stockID: number): Observable<stockReportDataModel> {
    return this.http.get<stockReportDataModel>(`${IceCreamApiUrl}/${endPoint}/GetReport?StockId=${stockID}`);
  }

  insert(companyId: number, createdDate: string, data: Stock[]): Observable<Stock[]> {
    return this.http.post<Stock[]>(`${IceCreamApiUrl}/${endPoint}/InsertStockData/${companyId}?createdDate=${createdDate}`, data);
  }

  checkCreatableStock(companyID: number):Observable<number>{
    return this.http.get<number>(`${IceCreamApiUrl}/${endPoint}/CheckCreatableStock?CompanyID=${companyID}`);
  }
}
