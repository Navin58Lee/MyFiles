import { Injectable } from '@angular/core';
import { of } from 'rxjs/observable/of';
import { Observable } from 'rxjs/Observable';
import { HttpClient } from '@angular/common/http';
import 'rxjs/add/operator/catch'
import { HttpErrorResponse } from '@angular/common/http/src/response';
import { Ibooking } from '../booking/booking';
import { Availableroomdetails } from '../booking/availableroomdetails';
import { OperationalResult } from '../shared/OperationResult';
import { debug } from 'util';
import { ConfirmBooking } from '../confirm-booking/ConfirmBooking';

@Injectable()
export class BookingService {
 // private bookingAPI: string = "http://localhost:61938/Booking";
 private bookingAPI : string="https://sanctuaryuibackdotnet.azurewebsites.net/Booking";
private test;
  // http://localhost:61938/api/Booking
  constructor(private http: HttpClient) { }

  // getBookingDetails () :IBooking

  // availableroom:Availableroomdetails;
  roomDetails: Availableroomdetails = {
    AssetId: "",
    RoomType: "",
    Availableroom: ""
  };


  result: OperationalResult = {
    Status: true,
    Message: "",
    Result: this.roomDetails,
    StatusCode: null

  };


  searchBooking(fromdate: string, todate: string, location: string): Observable<any> {
    // console.log(todate.toString()+"i am here");

    return this.http.get(this.bookingAPI + "/CheckAvailability", { params: { bookingFromDate: fromdate, bookingToDate: todate, locationCity: location } });
    // return of(this.result);
  }

  // confirmBooking(userId: string, fromdate: string, todate: string, location: string): Observable<any> {
  //   // console.log(todate.toString()+"i am here");

  //   return this.http.get(this.bookingAPI + "/CreateBooking", { params: { User: userId, bookingFromDate: fromdate, bookingToDate: todate, locationCity: location } });
  //   // return of(this.result);
  // }
  private handleError(err: HttpErrorResponse) {

  }

  confirmBooking(confirm):Observable<any>
{

return this.http.post(this.bookingAPI+"/CreateBooking",confirm);
} 

myBookings(email : string) : Observable<any>
{
  return this.http.get(this.bookingAPI + "/myBookings", { params: { email : email} });
}

cancelBooking(bookingId : any) : Observable<any>
{
  return this.http.delete(this.bookingAPI + "/cancel", { params: { bookingId : bookingId} });
}
}