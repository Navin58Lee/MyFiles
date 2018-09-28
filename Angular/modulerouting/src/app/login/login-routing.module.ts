import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LogincompComponent } from './logincomp/logincomp.component';
const routes: Routes = [
  {
    path: '',
    component: LogincompComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LoginRoutingModule { }
