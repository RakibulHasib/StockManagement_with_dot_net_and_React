import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ExpenseType } from 'src/app/enums/distributor-status.enum';
import { SalesDistributionService } from 'src/app/services/sales/sales-distribution.service';
import { NotificationService } from 'src/app/services/Shared/notification.service';

@Component({
  selector: 'app-expense-modal',
  templateUrl: './expense-modal.component.html',
  styleUrls: ['./expense-modal.component.css']
})
export class ExpenseModalComponent implements OnInit {
  amount!:number;
  expenseType = ExpenseType;
  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    private ref: MatDialogRef<ExpenseModalComponent>,
    private _distributeService: SalesDistributionService,
    private _notificationSvc: NotificationService
  ) { }

  ngOnInit() {
    this.getExpenseByDistributionId(this.data.salesDistributeId, this.data.expenseType);
  }

  closeModal(){
    this.ref.close();
   }
  
   getExpenseByDistributionId(salesDistributeId : number, expenseType: number) {
    if (salesDistributeId && expenseType) {
      this._distributeService.getExpenseById(salesDistributeId, expenseType)
        .subscribe(data => {
          this.amount = data;
        }, err => {
          this._notificationSvc.message("Failed to load data", "DISMISS");
        });
    } else {
      this._notificationSvc.message("Damage amount not found", "DISMISS");
    }
  }
}
