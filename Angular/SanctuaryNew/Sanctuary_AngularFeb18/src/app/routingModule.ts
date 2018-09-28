import{NgModule} from '@angular/core';
import {Routes,RouterModule} from '@angular/router';
import { ProfileComponent } from './profile/profile.component';
import { DashboardComponent } from './dashboard/dashboard.component';

import { BookingComponent} from './booking/booking.component';

import { CarouselComponent } from './carousel/carousel.component';
import {AuthenticationGuard} from './authentication.guard';
import { AppComponent } from './app.component';
import { ConfirmBookingComponent } from './confirm-booking/confirm-booking.component';
import { PreviousBookingsComponent } from './previous-bookings/previous-bookings.component';

const routes:Routes=[
  
 
    {path:'',component:CarouselComponent},
    {path:'profile',component:ProfileComponent,canActivate:[AuthenticationGuard]},
    {path: 'previous-bookings', component : PreviousBookingsComponent, canActivate: [AuthenticationGuard]},
    {path:'booking',component:BookingComponent, canActivate:[AuthenticationGuard]},
    {path:'bookingdetail',component:ConfirmBookingComponent,canActivate:[AuthenticationGuard]},
    {path:'**',redirectTo:"/", pathMatch:"full"}
];

@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRoutingModule{ }