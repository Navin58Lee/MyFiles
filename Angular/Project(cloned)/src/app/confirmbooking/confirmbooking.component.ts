import { ConfirmBooking } from './../shared/confirm-booking.model';
import { ConfirmserviceService } from './../shared/confirmservice.service';
import { Component, OnInit } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { NgForm } from "@angular/forms";
import Swal from 'sweetalert2';
import { Router } from "@angular/router";
import { Store } from "src/app/store.model";
import { EventEmitter } from "@angular/core";
import { Output } from "@angular/core";
import { CardComponent } from "src/app/card/card.component";
import { StoreServiceService } from "src/app/store-service.service";


@Component({
  selector: 'app-confirmbooking',
  templateUrl: './confirmbooking.component.html',
  styleUrls: ['./confirmbooking.component.css']
})
export class ConfirmbookingComponent implements OnInit {
  confirmdata: Store;
  
  constructor(private service: StoreServiceService,private route:Router) {
    
   }
 k:any;
  opt:any;
  date1 = '' // from date
  date2 = '' // to date
  Roomdet: any;
  diff:any; //to find date difference
   discount:number;
   Roomcost:number;
  sum:number;
  RoomType='';
  
  x:any;//to find diffrence of dates
  public  Hotel:Store[];
    nameId:any;//to show number of guests
  ngOnInit() {
    this.confirmdata= this.service.store;
    this.receivingValue();
    this.nameId=1;


this.sum=this.nameId*this.diff*this.Roomcost;
this.discount=((20*this.sum)/100);


  }
  public book: ConfirmBooking;
  confirm(){
    
  this.book = new ConfirmBooking();
  if(this.sum>1000)
    {    this.book.discountAmount=this.discount;
      this.book.bookingAmount=this.sum-this.discount;
    }else{
      this.book.discountAmount=0;
      this.book.bookingAmount=this.sum;
    }

    this.book.checkInDate=this.date1;
    this.book.checkOutDate=this.date2;
    

   
    this.service.Confirmbooking(this.book).subscribe(y=>{

      if(y)
        {
          Swal({
            title: 'Booking is Confirmed',
          
            type: 'success',
           
            confirmButtonColor: '#3085d6',
           
            confirmButtonText: 'Ok'
          }).then((result) => {
            if (result.value) {
              this.route.navigate(['/Home']);
            }
          })
        }
    }) 
  }

  Discount()
  {
    this.sum=this.nameId*this.diff*this.Roomcost;
    this.discount=((20*this.sum)/100);
   
  }

  public receivingValue(){
    this.confirmdata= this.service.store;
    this.date1=this.confirmdata.hotelFromDate;
    this.date2=this.confirmdata.hotelToDate;
    this.diff=1;
    this.Roomcost=this.confirmdata.hotelPrice;
    this.RoomType=this.confirmdata.hotelRoomType;
   
  }

}
