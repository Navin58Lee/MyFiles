import { Component, OnInit } from '@angular/core';
import { History } from "src/app/shared/history";
import { HistoryserviceService } from "src/app/historyservice.service";
import { UserService } from "src/app/shared/user.service";
import { Router } from "@angular/router";
import  Swal  from 'sweetalert2';

@Component({
  selector: 'app-bookinghistory',
  templateUrl: './bookinghistory.component.html',
  styleUrls: ['./bookinghistory.component.css']
})
export class BookinghistoryComponent implements OnInit {
  minDate = new Date();

  constructor(private historyService: HistoryserviceService, private userService: UserService) { }
  hotelnew: History = new History();
  historyData: Array<History>;
  public todayDate: string = (new Date()).toISOString().split("T")[0];
  ngOnInit() {
    
  }
  hello(){
    this.historyService.booking(this.userService.Loggeduser.Uid).subscribe(data => {
      this.historyData = data;
  });
}
clear(bid: any){
  this.historyService.cancel(bid).subscribe();
  this.hello();
  if(bid)
    {
      Swal("Your Booking is Cancelled Successfully");
    }
}
}