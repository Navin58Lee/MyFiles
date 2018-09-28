import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ConfirmbookingComponent } from "src/app/confirmbooking/confirmbooking.component";
import { SearchComponent } from "src/app/search/search.component";
import { PagenotfoundComponent } from "src/app/pagenotfound/pagenotfound.component";
import { DashboardCompComponent } from "src/app/dashboard-comp/dashboard-comp.component";
import { LoginCompComponent } from './login-comp/login-comp.component';



const routes: Routes = [
  { path: '', redirectTo: '/Home', pathMatch: 'full' },
  { path: 'Home', component: DashboardCompComponent },
  { path: 'Login', component: LoginCompComponent },
  { path: 'Search', component: SearchComponent },
  { path: 'confirmbooking', component: ConfirmbookingComponent },
  { path: '**', component: PagenotfoundComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

