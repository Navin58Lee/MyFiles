import { Component, OnInit,Input } from '@angular/core';
import { Store } from "src/app/store.model";
import { ConfirmbookingComponent } from "src/app/confirmbooking/confirmbooking.component";
import { Router } from "@angular/router";
import { ViewChild } from "@angular/core";
import { ConfirmserviceService } from "src/app/shared/confirmservice.service";
import { StoreServiceService } from "src/app/store-service.service";

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {

  constructor(private route:Router,private confirm: StoreServiceService) { }
 
  @Input() public hotelInfo; 
  ngOnInit() {
    
  }

  public Hotel :Store
  confirmBooking(BookedHotel){
 this.confirm.store=BookedHotel;
 
    this.route.navigate(['/confirmbooking']);

  }
  
}
