import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SignupRoutingModule } from './signup-routing.module';
import { SignupcompComponent } from './signupcomp/signupcomp.component';

@NgModule({
  imports: [
    CommonModule,
    SignupRoutingModule
  ],
  declarations: [SignupcompComponent]
})
export class SignupModule { }
