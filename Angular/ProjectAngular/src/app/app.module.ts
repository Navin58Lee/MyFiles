import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{ FormsModule } from '@angular/forms';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SearchComponent } from './search/search.component';
import { HttpClientModule } from '@angular/common/http';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
// ----------------------------
import { CardComponent } from './card/card.component';
import {MatGridListModule,MatCardModule,MatMenuModule,MatIconModule,MatButtonModule} from '@angular/material';
import{LayoutModule} from '@angular/cdk/layout';
import { ConfirmbookingComponent } from './confirmbooking/confirmbooking.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';

// ----------------------------
import { UserService} from './shared/user.service';
import { RouterModule } from '@angular/router';
import { DashboardCompComponent } from './dashboard-comp/dashboard-comp.component';
import { SignupCompComponent } from './signup-comp/signup-comp.component';
import { LoginCompComponent } from './login-comp/login-comp.component';
import { AuthGuard } from "src/app/auth/auth.guard";
import { BookinghistoryComponent } from './bookinghistory/bookinghistory.component';



//--------------------------------

@NgModule({
  declarations: [
    AppComponent,
    SearchComponent,
    CardComponent,
    ConfirmbookingComponent,
    PagenotfoundComponent,
    DashboardCompComponent,
    SignupCompComponent,
    LoginCompComponent,
    BookinghistoryComponent
 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatGridListModule,
    MatCardModule,
    MatMenuModule,
    MatIconModule,
    MatButtonModule,
    LayoutModule

    
    
    


  ],
  providers: [UserService, AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
