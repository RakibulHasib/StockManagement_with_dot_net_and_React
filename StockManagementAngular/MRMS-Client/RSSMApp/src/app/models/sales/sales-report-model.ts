export class SalesReportModel {
    constructor(
      public salesDistributeId?: number,
      public concernPerson?: string,
      public creationTime?: Date,
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
    public returnQuantity?: number,
    public salesQuantity?: number,
    public totalSalesPrice?: number,
    public creationTime?: Date
    ) { }
  }
  
  
  

  
