import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MaterialModule } from './design.module';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import{ConfirmEqualValidatorDirective} from './shared/confirm-equal-validator.directive';
import { ProfileComponent } from './profile/profile.component';

import { HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CarouselComponent } from './carousel/carousel.component';
import { AppRoutingModule } from './routingModule';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BookingComponent } from './booking/booking.component';
import { CookieService } from 'ngx-cookie-service';
import {BehaviorSubject} from 'rxjs/BehaviorSubject';
import { UserService } from './shared/user.service';

import { BookingService } from './shared/booking.service';
import { ResultService } from './shared/result.service';
import { BookingdetailsService } from './shared/bookingdetails.service';

import {AuthenticationGuard} from './authentication.guard';
import { ConfirmBookingComponent } from './confirm-booking/confirm-booking.component';
import { PreviousBookingsComponent } from './previous-bookings/previous-bookings.component';


@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    CarouselComponent,
    ConfirmEqualValidatorDirective,
    BookingComponent,
    ProfileComponent,
    ConfirmEqualValidatorDirective,
   
    ConfirmBookingComponent,
   
    PreviousBookingsComponent
    
  ],
  imports: [
    BrowserModule, 
    ReactiveFormsModule,
    FormsModule,
    MaterialModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
  ],
  providers: [ UserService, CookieService,BookingService, CookieService, ResultService,BookingdetailsService,
    UserService, CookieService, ResultService ,AuthenticationGuard],

  bootstrap: [AppComponent]
})
export class AppModule { }
