import { Component, OnInit } from '@angular/core';
//import { BookingService } from './shared/booking.service';
import { BookingService } from '../shared/booking.service';
import { BookingdetailsService } from '../shared/bookingdetails.service';
import { Bookingdetail } from '../booking/bookingdetail';
import { Pipe, PipeTransform } from '@angular/core';
import { DatePipe } from '@angular/common';
import { Router } from '@angular/router';
import swal from 'sweetalert2';
import { ConfirmBooking } from '../confirm-booking/ConfirmBooking';

@Component({
  selector: 'app-confirm-booking',
  templateUrl: './confirm-booking.component.html',
  styleUrls: ['./confirm-booking.component.css']
})
export class ConfirmBookingComponent implements OnInit {

  public result: Bookingdetail = {
    NoOfAvailableRoom: "",
    Roomprice: "",
    ToDate: "",
    FromDate: "",
    RoomType:"",
    AssetId:""
  }
   public confirm: ConfirmBooking;

  constructor(private router:Router,private _bookingdetails: BookingService, private bookingdetail: BookingdetailsService) { }
  
  // confirmBooking(user:string,NoOfRoom:string,FromDate:string,ToDate:string,       ){
  //   swal("Booking Confirmed", "Thank You");
    
  //   this.router.navigate(["/booking"]);
  
  ngOnInit() {
    this.result.NoOfAvailableRoom = JSON.parse(localStorage.getItem("NoOfAvailableRooms"));
    this.result.Roomprice = JSON.parse(localStorage.getItem("RoomPrice"));
    this.result.ToDate = localStorage.getItem("todate");
    this.result.FromDate = localStorage.getItem("fromdate");
    this.result.RoomType = localStorage.getItem("RoomType");
    this.result.AssetId = localStorage.getItem("AssetId");
    console.log(this.result);
    var datePipe = new DatePipe("en-US");
    this.result.ToDate = datePipe.transform( this.result.ToDate, 'MM/dd/yyyy');
    this.result.FromDate = datePipe.transform( this.result.FromDate, 'MM/dd/yyyy');

  }
  

  
confirmBooking() : void
{ 

this.confirm = new ConfirmBooking();
this.confirm.Asset_Id=this.result.AssetId;
this.confirm.NoOfRooms=this.result.NoOfAvailableRoom;
this.confirm.BookingToDate=this.result.ToDate;
this.confirm.BookingFromDate=this.result.FromDate;
this.confirm.User_Id=localStorage.getItem("userid");
this.confirm.User_Email=localStorage.getItem("email");;

this._bookingdetails.confirmBooking(this.confirm).subscribe();

} 
}






