import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { NotificationService } from 'src/app/services/Shared/notification.service';
import { ConfirmDialogComponent } from '../../shared/confirm-dialog/confirm-dialog.component';
import { Subscription, throwError } from 'rxjs';
import { MatDialog } from '@angular/material/dialog';
import { Dailydatadbmodel } from '../../../models/DailyDataModel/dailydatadbmodel';
import { StockService } from '../../../services/Savoy/savoy.service';
import { DatePipe } from '@angular/common';
import { ActivatedRoute } from '@angular/router';
import { Company } from 'src/app/models/companyenum/company';


@Component({
  selector: 'app-savoy-view',
  templateUrl: './stock-view.component.html',
  styleUrls: ['./stock-view.component.css']
})
export class StockViewComponent implements OnInit, OnDestroy {
  companyId!: number;
  paramsSubscription! : Subscription;

  dailyData: Dailydatadbmodel[] = [];
  dataSource: MatTableDataSource<Dailydatadbmodel> = new MatTableDataSource(this.dailyData);

  @ViewChild(MatSort, { static: false }) sort!: MatSort;
  @ViewChild(MatPaginator, { static: false }) paginator!: MatPaginator;

  columnList: string[] = ["createdDate", "totalSalesQuantity", "totalAmount","actions"];
  startDate: string = '';
  endDate: string = '';

  constructor(
    private dailyDataSvc: StockService,
    private _notificationSvc: NotificationService,
    private _dialog: MatDialog,
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit() {
    const today = new Date();
    this.endDate = this.formatDate(today);
    const fifteenDaysAgo = new Date();
    fifteenDaysAgo.setDate(fifteenDaysAgo.getDate() - 15);
    this.startDate = this.formatDate(fifteenDaysAgo);

    this.paramsSubscription = this.activatedRoute.params.subscribe((params) => {
      const companyKey = params['company'];
      this.companyId = +Company[companyKey];
      this.fetchData();
    });
  }

  ngOnDestroy(){
    this.paramsSubscription.unsubscribe();
  }
  
  formatDate(date: Date): string {
    const year = date.getFullYear();
    const month = String(date.getMonth() + 1).padStart(2, '0');
    const day = String(date.getDate()).padStart(2, '0');
    return `${year}-${month}-${day}`;
  }

  fetchData() {
    if (this.startDate && this.endDate) {
      this.dailyDataSvc.getSavoyDashboardDataPerDay(this.companyId, this.startDate, this.endDate)
        .subscribe(data => {
          this.dailyData = data;
          this.dataSource.data = this.dailyData;
          console.log(this.dataSource);
          this.dataSource.paginator = this.paginator;
          this.dataSource.sort = this.sort;
        }, err => {
          this.dailyData = [];
          this._notificationSvc.message("Failed to load data", "DISMISS");
        });
    } else {
      this._notificationSvc.message("Please provide both Start Date and End Date", "DISMISS");
    }
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

}