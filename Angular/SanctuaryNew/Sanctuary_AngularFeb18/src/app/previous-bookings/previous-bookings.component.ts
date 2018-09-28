import { Component, OnInit } from '@angular/core';
import { BookingService } from '../shared/booking.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'previous-bookings',
  templateUrl: './previous-bookings.component.html',
  styleUrls: ['./previous-bookings.component.css']
})
export class PreviousBookingsComponent implements OnInit {

  displayedColumns = ['BookingFromDate', 'BookingToDate', 'NoOfRooms', 'LocationCity'];
  operationResult : any;
  dataSource : any;
  datasource2 : any;
  tempDate : any;
  constructor(private _bookingdetails: BookingService) {
   }

  ngOnInit() {
    //this._bookingdetails.myBookings(localStorage.getItem('email').toString()).subscribe(data => {
    this._bookingdetails.myBookings("skb30496@gmail.com").subscribe(data => {
        this.operationResult = data;
      console.log(this.operationResult);
      this.dataSource = this.operationResult.Result;
      console.log(this.dataSource);
    });    
  }

  view_booking(row)
  {
    this.datasource2 = row;    
    var datePipe = new DatePipe("en-US");        
    this.datasource2.BookingFromDate = datePipe.transform(this.datasource2.BookingFromDate, 'dd-MMM-yyyy');
    this.datasource2.BookingToDate = datePipe.transform(this.datasource2.BookingToDate, 'dd-MMM-yyyy');
    if(this.datasource2.IsDelete == true)
    {
      this.datasource2.status = -1;
    }
    else
    {
      this.tempDate = datePipe.transform(Date.now(), 'dd-MMM-yyyy');
      if(new Date(this.tempDate) > new Date(this.datasource2.BookingFromDate))
      {
        this.datasource2.status = 1;
      }
      else
      {
        this.datasource2.status = 0;
      }
    }  
  }
  
  cancel_booking(row)
  {
    this._bookingdetails.cancelBooking(row.BookingId).subscribe(data => {

    });
  }
}