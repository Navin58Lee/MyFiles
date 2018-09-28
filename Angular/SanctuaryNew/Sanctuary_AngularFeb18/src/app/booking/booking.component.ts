import { Component, OnInit } from '@angular/core';
import { Ibooking } from '../booking/booking';
import { BookingService } from '../shared/booking.service';
import { Location } from '@angular/common';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { NgForm } from '@angular/forms/src/directives/ng_form';
import { OperationalResult } from '../shared/OperationResult';
import { Availableroomdetails } from './availableroomdetails';
import { Pipe, PipeTransform } from '@angular/core';
import { DatePipe } from '@angular/common';
import { BookingdetailsService } from '../shared/bookingdetails.service';
import { Bookingdetail } from './bookingdetail';
import { Router } from '@angular/router';
import { debug } from 'util';


@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent implements OnInit {

  available: Availableroomdetails =
    {
      AssetId: null,
      RoomType: '',
      Availableroom: ''
    }

  private book: Ibooking;

  isSearchButtonClicked: boolean;

  ngOnInit() {
    this.isSearchButtonClicked = false;
  }


  result: OperationalResult = {
    Status: false,
    Message: "",
    Result: this.available,
    StatusCode: null

  };
  minDate:Date;
  maxDate:Date;
 

  constructor(private _datapassing: BookingService, private bookingdetails: BookingdetailsService, private router: Router) {
    this.minDate = new Date();
    this.maxDate= new Date();
    this.maxDate.setDate(this.minDate.getDate() + 60);
   }

  bookingForm = new FormGroup({
    todate: new FormControl('', Validators.required),
    fromdate: new FormControl('', Validators.required),
    location: new FormControl('', Validators.required)
  });
  
 
  

  



  locationGroups = [
    {
      name: 'Australia',
      location: [
        { value: 'Sedney', viewValue: 'Sydney' },
        { value: 'Melbourne', viewValue: 'Melbourne' },
        { value: 'Brisbane', viewValue: 'Brisbane' },
        { value: 'Perth', viewValue: 'Perth' },
        { value: 'Adelaide', viewValue: 'Adelaide' },
        { value: 'Canberra', viewValue: 'Canberra' },
        { value: 'Hobart', viewValue: 'Hobart' },
        { value: 'Townsville', viewValue: 'Townsville' },
        { value: 'Darwin', viewValue: 'Darwin' },
        { value: 'Cairns', viewValue: 'Cairns' }
      ]
    },
    {
      name: 'New Zealand',
      location: [
        { value: 'Auckland', viewValue: 'Auckland' },
        { value: 'Wellington', viewValue: 'Wellington' },
        { value: 'Christchurch', viewValue: 'Christchurch' },
        { value: 'Hamilton', viewValue: 'Hamilton' },
        { value: 'Tauranga', viewValue: 'Tauranga' },
        { value: 'Napier', viewValue: 'Napier' },
        { value: 'Dunedin', viewValue: 'Dunedin' },
        { value: 'Palmerston', viewValue: 'Palmerston' },
        { value: 'New Plymouth', viewValue: 'New Plymouth' },
        { value: 'Nelson', viewValue: 'Nelson' },
      ]
    }
  ];



  private bookingResult: Bookingdetail;

  setbookingDetails(NoOfAvailableRooms: string, RoomPrice: string, todate: string, fromdate: string, roomtype: string,AssetId:string): void {
    localStorage.setItem("NoOfAvailableRooms", NoOfAvailableRooms);
    localStorage.setItem("RoomPrice", RoomPrice);
    localStorage.setItem("todate", todate);
    localStorage.setItem("fromdate", fromdate);
    localStorage.setItem("RoomType", roomtype);
    localStorage.setItem("AssetId", AssetId);
    this.router.navigate(["/bookingdetail"]);
    window.location.reload();
  }


  searchBooking(bookingForm): void {
    let SearchToDate = bookingForm.value.todate;
    let SearchFromDate = bookingForm.value.fromdate;
    let SearchLocation = bookingForm.value.location;


    var datePipe = new DatePipe("en-US");
    SearchToDate = datePipe.transform(SearchToDate, 'MM/dd/yyyy');
    SearchFromDate = datePipe.transform(SearchFromDate, 'MM/dd/yyyy');
    console.log(SearchToDate);

    console.log(SearchToDate.toString());
    this._datapassing.searchBooking(SearchFromDate, SearchToDate, SearchLocation).subscribe(
      (data: any) => {

        this.result = data.valueOf();
        console.log(this.result.Result[0]);

        if (this.result.Status == true) {
          this.isSearchButtonClicked = true;
        }
      }
    );
    

  }

}
