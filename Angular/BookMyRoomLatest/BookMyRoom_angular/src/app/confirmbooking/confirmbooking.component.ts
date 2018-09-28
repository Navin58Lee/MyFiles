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
  public booking:ConfirmBooking={
     roomId :null,
     bookingDate:'',
     checkInDate:null,
      checkOutDate :null,
      bookingAmount :null,
     discountAmount :null,
}
  
  constructor(public service: StoreServiceService, private route: Router, private userservice: UserService) {

  }

 
  diff: any; //to find date difference
  
  Roomcost: number;
  sum: number;
  RoomType = '';
  UserewardsDiscount: boolean;//button to disable use rewards

 
 public nameId: any;//to show number of guests
public  rewardsum:number;
latestrewards:number=0;
  ngOnInit() {
    

    this.receivingValue(); // for accessing search page components


    this.GetRewardsPoint(); // calling function for service
     this.sum = this.nameId * this.diff * this.Roomcost; //Initiallly the sum
    // this.discount = 0;

this.rewardsum=0; // Rewards point to amount 

  }
  dataupdate:any;//No use just used in subscribe
  public userrewardsupdate:User; // updating user rewards
  public book: ConfirmBooking; // object for sending values to webapi
 public RewardPoints: number=0; // used for storing rewards
  confirm() //confirm booking 
  {

    this.book = new ConfirmBooking();
    
      this.book.discountAmount = this.booking.discountAmount;
      this.book.bookingAmount = this.booking.bookingAmount;
    this.book.checkInDate = this.booking.checkInDate;
    this.book.checkOutDate = this.booking.checkOutDate;
    this.book.roomId = this.confirmpagedata.hotelId;
     if(this.book.bookingAmount>100)
       {
         this.latestrewards=  this.RewardPoints+(this.confirmpagedata.hotelPrice/100);
       }

    this.userservice.Loggeduser.RewardPoints=Math.round(this.latestrewards);
this.service.updaterewards(this.userservice.Loggeduser).subscribe();
    this.service.Confirmbooking(this.book).subscribe(y => {

      if (y) {
        Swal({
          title: 'Booking is Confirmed',

          type: 'success',

          confirmButtonColor: '#3085d6',

          confirmButtonText: 'Ok'
        }).then((result) => {
          if (result.value) {
           this.userservice.LoggedUserDetails();
            this.route.navigate(['/Search']);
          
          }
        })
      }
      else{
        Swal("Arreyyy Somethng wrng");
      }
    })
  }
  GetRewardsPoint() //function to get reward points from service
  {
  
   this.LoggedUser=JSON.parse(localStorage.getItem('currentuser'));
   this.RewardPoints=this.LoggedUser.RewardPoints;
    if (this.RewardPoints <25) {
      this.UserewardsDiscount = false;  // if no reward points we make button disable
    }

    else {
      this.UserewardsDiscount = true;
    }

  }


  public receivingValue() //  accessing previous page data
  {
    this.confirmpagedata =  JSON.parse(localStorage.getItem('bookinghotel'));
    this.userservice.LoggedUserDetails();
    this.nameId = 1; 
    this.booking.checkInDate=new Date(this.confirmpagedata.hotelFromDate);
    this.booking.checkOutDate=new Date(this.confirmpagedata.hotelToDate);
    this.diff = this.booking.checkOutDate.getDate() - this.booking.checkInDate.getDate();
     this.Roomcost = this.confirmpagedata.hotelPrice;
     this.RoomType = this.confirmpagedata.hotelRoomType;
     this.booking.discountAmount=0;
    this.booking.bookingAmount=this.nameId* this.diff * this.Roomcost;
    

  }
  GuestAddition() //Function to add number of guests
  {
    this.booking.bookingAmount=this.nameId * this.diff * this.Roomcost - this.booking.discountAmount;
  }
  UseRewards() //To use rewards 
  { 
    this.RewardPoints=this.RewardPoints-25;
    this.rewardsum=this.rewardsum+25;
    this.booking.discountAmount = this.rewardsum * 10;
    this.booking.bookingAmount=this.booking.bookingAmount-this.booking.discountAmount;
if(this.RewardPoints<25 || this.booking.bookingAmount==0 ||(this.booking.discountAmount)>=500)
    {
    this.UserewardsDiscount = false;
    }
    else{
      this.UserewardsDiscount=true;
    }
  }

}
