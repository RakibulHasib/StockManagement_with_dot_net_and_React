export class SalesReportModel {
    constructor(
      public salesDistributeId?: number,
      public concernPerson?: string,
      public companyName?: string,
      public creationTime?: Date,
      public damageAmount?: number,
      public afterDamagePrice?: number,
      public srcommission?: number,
      public afterSrCommission?: number,
      public dsrcommission?: number,
      public afterDsrCommission?: number,
      public reportDetails?: SalesReportDetailModel[]
    ) { }
  
  }

export class SalesReportDetailModel {
    constructor(
    public salesDistributeDetailsId?: number,
    public salesDistributeId?: number,
    public productId?: number,
    public productName?: string,
    public price?: number,
    public receiveQuantity?: number,
    public receivePrice?: number,
    public returnQuantity?: number,
    public returnPrice?: number,
    public salesQuantity?: number,
    public totalSalesPrice?: number,
    public damageQuantity?: number,
    public creationTime?: Date
    ) { }
  }