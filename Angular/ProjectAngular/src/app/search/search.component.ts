import  Swal  from 'sweetalert2';
import { Component, OnInit } from '@angular/core';
import { Store } from "src/app/store.model";
import { StoreServiceService } from "src/app/store-service.service";
import { NgForm } from "@angular/forms";
import { Router } from "@angular/router";
@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})

export class SearchComponent implements OnInit 
{
  userClaims: any;
  str: Store = new Store();

  constructor(private storeServiceService: StoreServiceService, private router: Router) { }

  recievedData: Array<Store> = new Array<Store>();
  searchData: Array<Store>;
  num: number;
  public todayDate: string = (new Date()).toISOString().split("T")[0];
  public tomorrowDate: string = new Date(new Date().getTime() + 86400000).toISOString().split("T")[0];
  errormsg: string;
  stored: Store = new Store();
  search1: Array<Store> = new Array<Store>();

  ngOnInit() 
  {
    this.str.hotelCity = "Bhubaneswar";
    this.str.hotelToDate = this.tomorrowDate;
    this.str.hotelFromDate = this.todayDate;
    this.str.hotelRoomType = "Single";

  }
  show(form: NgForm) 
  {
    this.storeServiceService.Searching(form.value).subscribe(data => {
      this.searchData = data;
      console.log(data);
      console.log(this.searchData);
      if(this.searchData.length==0)
        {
          Swal("Please give proper Checkin Date");
        }
    },
      error => {
        console.log(error);
      });
    if (this.searchData == null) {
      this.errormsg = "no rooms are available";
    }
  }
  Logout() {
    localStorage.removeItem('userToken');
    this.router.navigate(['/Home']);
  }
  // history(form: NgForm){
  //   this.storeServiceService.BookingHistory(form.value).subscribe(data => {
  //     this.searchData = data;
  // }
}
