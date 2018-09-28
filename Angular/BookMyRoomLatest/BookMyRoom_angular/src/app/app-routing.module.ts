import { AuthGuard } from 'src/app/auth/auth.guard';
import { NgModule } from '@angular/core';
import { Routes, RouterModule, CanActivate } from '@angular/router';
import { ConfirmbookingComponent } from "src/app/confirmbooking/confirmbooking.component";
import { SearchComponent } from "src/app/search/search.component";
import { PagenotfoundComponent } from "src/app/pagenotfound/pagenotfound.component";
import { DashboardCompComponent } from "src/app/dashboard-comp/dashboard-comp.component";
import { LoginCompComponent } from './login-comp/login-comp.component';

// import { BookinghistoryComponent } from "src/app/bookinghistory/bookinghistory.component";


const routes: Routes = [
   { path: '', redirectTo: '/Home', pathMatch: 'full' },
  {path:'Home',component:DashboardCompComponent},
  {path:'Login',component:LoginCompComponent,canActivate:[AuthGuard]},
  {path:'Search',component:SearchComponent,canActivate:[AuthGuard]},
   {path:'confirmbooking',component:ConfirmbookingComponent,canActivate:[AuthGuard]},
  //  {path: 'bookinghistory',component:BookinghistoryComponent},
   {path:'**',component:PagenotfoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

