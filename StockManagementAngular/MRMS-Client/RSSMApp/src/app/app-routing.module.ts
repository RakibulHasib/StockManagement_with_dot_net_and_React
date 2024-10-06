import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './component/home/home.component';
import { FileContainerComponent } from './component/shared/file-container/file-container.component';
import { RegisterComponent } from './component/Authentication/register/register.component';
import { SignInComponent } from './component/Authentication/sign-in/sign-in.component';
import { AuthGuard } from './component/auth/guards/auth.guard';
import { StockViewComponent } from './component/stock/stock-view/stock-view.component';
import { StockCreateComponent } from './component/stock/stock-create/stock-create.component';
import { StockReportComponent } from './component/report/stock-report/stock-report.component';
import { DistributionCreateComponent } from './component/distribution/distribution-create/distribution-create.component';
import { ProductViewComponent } from './component/Product/product-view/product-view.component';
import { DistributionViewComponent } from './component/distribution/distribution-view/distribution-view.component';
import { DistributionReportComponent } from './component/distribution/distribution-report/distribution-report.component';
import { CompanyViewComponent } from './component/Company/company-view/company-view.component'
import { ConcernViewComponent } from './component/concernPerson/concern-view/concern-view.component';
import { UserviewComponent } from './component/User/userview/userview.component';



const routes: Routes = [
  { path: '', component: SignInComponent },
  { path: 'home', component: HomeComponent,canActivate: [AuthGuard] },
  { path: 'signUp', component: RegisterComponent },
  { path: 'signin', component: SignInComponent },
  { path: 'FileContainer', component: FileContainerComponent, canActivate: [AuthGuard] },
  { path: 'stock-view', component: StockViewComponent, canActivate: [AuthGuard] },
  { path: 'stock-create/:id', component: StockCreateComponent, canActivate: [AuthGuard] },
  { path: 'stock-report/:id', component: StockReportComponent, canActivate: [AuthGuard] },
  { path: 'sales-create', component: DistributionCreateComponent, canActivate: [AuthGuard] },
  { path: 'sales-view', component: DistributionViewComponent, canActivate: [AuthGuard] },
  { path:  'sales-report/:id', component:DistributionReportComponent,canActivate:[AuthGuard]},
  { path: 'productView', component: ProductViewComponent, canActivate: [AuthGuard] },
  { path: 'companyview', component: CompanyViewComponent, canActivate: [AuthGuard] },
  { path: 'concernpersonview', component: ConcernViewComponent, canActivate: [AuthGuard] },
  { path: 'userview',component:UserviewComponent,canActivate:[AuthGuard]},
  { path: '**', component: SignInComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
