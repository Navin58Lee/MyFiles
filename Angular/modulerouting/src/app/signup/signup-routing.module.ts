import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SignupcompComponent } from './signupcomp/signupcomp.component';

const routes: Routes = [
  {
    path: '',
    component: SignupcompComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SignupRoutingModule { }
