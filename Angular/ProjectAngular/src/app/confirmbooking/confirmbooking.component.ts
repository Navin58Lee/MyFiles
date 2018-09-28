import { User } from 'src/app/shared/user.model';
import { ConfirmBooking } from './../shared/confirm-booking.model';
import { ConfirmserviceService } from './../shared/confirmservice.service';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { NgForm } from "@angular/forms";
import Swal from 'sweetalert2';
import { Router } from "@angular/router";
import { Store } from "src/app/store.model";
import { EventEmitter } from "@angular/core";
import { Output } from "@angular/core";
import { CardComponent } from "src/app/card/card.component";
import { StoreServiceService } from "src/app/store-service.service";
import { UserService } from "src/app/shared/user.service";


@Component({
  selector: 'app-confirmbooking',
  templateUrl: './confirmbooking.component.html',
  styleUrls: ['./confirmbooking.component.css']
})
export class ConfirmbookingComponent implements OnInit {
  confirmpagedata: Store;
  LoggedUser: User;
  constructor(public service: StoreServiceService, private route: Router, public userservice: UserService) {

  }

  date1: Date; // from date
  date2: Date; // to date
  Roomdet: any;
  diff: any; //to find date difference
  discount: number;
  Roomcost: number;
  sum: number;
  RoomType = '';
  dataupdate:any;
  UserewardsDiscount: boolean;//button to disable use rewards
  x: any;//to find diffrence of dates
  public Hotel: Store[];
 public nameId: any;//to show number of guests
public  rewardsum:number;
latestrewards:number=0;
  ngOnInit() {

    this.confirmpagedata = this.service.store;
    this.receivingValue(); // for accessing search page components
    this.nameId = 1; // number of guests

    this.GetRewardsPoint(); // calling function for service
    this.sum = this.nameId * this.diff * this.Roomcost; //Initiallly the sum
    this.discount = 0;
this.rewardsum=0; // Rewards point to amount 

  }
  public userrewardsupdate:User; // updating user rewards
  public book: ConfirmBooking; // object for sending values to webapi
 public RewardPoints: number=0; // used for storing rewards
  confirm() //confirm booking 
  {

    this.book = new ConfirmBooking();
    
      this.book.discountAmount = this.discount;
      this.book.bookingAmount = this.sum;
    

  

    this.book.checkInDate = this.date1;
    this.book.checkOutDate = this.date2;
    this.book.roomId = this.confirmpagedata.hotelId;
     if(this.sum>100)
       {
         this.latestrewards=  this.RewardPoints+(this.nameId * this.diff * this.Roomcost/100);
       }

    this.userservice.Loggeduser.RewardPoints=Math.round(this.latestrewards);
this.service.updaterewards(this.userservice.Loggeduser).subscribe(x=>{
this.dataupdate=x
});
    this.service.Confirmbooking(this.book).subscribe(y => {

      if (y) {
        Swal({
          title: 'Booking is Confirmed',

          type: 'success',

          confirmButtonColor: '#3085d6',

          confirmButtonText: 'Ok'
        }).then((result) => {
          if (result.value) {
            this.route.navigate(['/Search']);
          }
        })
      }
      else{
        Swal("Booking Not done sorry!");
      }
    })
  }
  GetRewardsPoint() //function to get reward points from service
  {
    this.RewardPoints = this.userservice.Loggeduser.RewardPoints;
    if (this.RewardPoints <25) {
      this.UserewardsDiscount = false;  // if no reward points we make button disable
    }

    else {
      this.UserewardsDiscount = true;
    }

  }


  public receivingValue() // calling service and accessing previous page data
  {
    this.confirmpagedata = this.service.store;
    this.date1 = new Date(this.confirmpagedata.hotelFromDate);
    this.date2 = new Date(this.confirmpagedata.hotelToDate);
    this.diff = this.date2.getDate() - this.date1.getDate();
    this.Roomcost = this.confirmpagedata.hotelPrice;
    this.RoomType = this.confirmpagedata.hotelRoomType;

  }
  GuestAddition() //Function to add number of guests
  {

    this.sum = this.nameId * this.diff * this.Roomcost - this.discount;
  }
  UseRewards() //To use rewards 
  { 
    this.RewardPoints=this.RewardPoints-25;
    this.rewardsum=this.rewardsum+25;
    this.discount = this.rewardsum * 10;
    this.sum = this.sum - this.discount;
if(this.RewardPoints<25 || this.sum==0)
    {
    this.UserewardsDiscount = false;
    }
    else{
      this.UserewardsDiscount=true;
    }
  }



}
