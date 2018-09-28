import  Swal  from 'sweetalert2';
import { Component, OnInit } from '@angular/core';
import { Store } from "src/app/store.model";
import { StoreServiceService } from "src/app/store-service.service";
import { NgForm } from "@angular/forms";
import { Router } from "@angular/router";
import { User } from "src/app/shared/user.model";


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})

export class SearchComponent implements OnInit 
{
  
  searchfilter: Store = new Store();

  constructor(private storeServiceService: StoreServiceService, private router: Router) { }

  searchData: Array<Store>;
  public todayDate: string = (new Date()).toISOString().split("T")[0];
  public tomorrowDate: string = new Date(new Date().getTime() + 86400000).toISOString().split("T")[0];
  errormsg: string;
  LoggedUser:User;
  name:any;
  ngOnInit() 
  {
    this.searchfilter.hotelCity = "Bhubaneswar";
    this.searchfilter.hotelToDate = this.tomorrowDate;
    this.searchfilter.hotelFromDate = this.todayDate;
    this.searchfilter.hotelRoomType = "Single";
    this.LoggedUser=JSON.parse(localStorage.getItem('currentuser'));
    this.name=this.LoggedUser.name;
  }
  show(form: NgForm) 
  {
    this.storeServiceService.Searching(form.value).subscribe(data => {
      this.searchData = data;
     
      if(this.searchData.length==0 && this.searchfilter.hotelFromDate<this.todayDate)
        {
          Swal("You Cannot Book a Room on this Date");
        }
         if(this.searchData.length==0 && this.searchfilter.hotelFromDate>this.searchfilter.hotelToDate)
          {
            Swal("CheckIn date cannot be greater than CheckOut Date");
          }
           if(this.searchData.length==0 && (this.searchfilter.hotelFromDate==this.searchfilter.hotelToDate)&&(this.searchfilter.hotelFromDate!='')&&(this.searchfilter.hotelToDate!=''))
          {
            Swal("Checkout Date and CheckIn date Should not be same");
          }
          if(this.searchData.length==0 && (this.searchfilter.hotelFromDate == '' || this.searchfilter.hotelToDate == ''))
            Swal("Please give input fields");
        if(this.searchData.length==0 && this.searchfilter.hotelFromDate<this.searchfilter.hotelToDate && this.searchfilter.hotelFromDate!=this.searchfilter.hotelToDate&&this.searchfilter.hotelFromDate>=this.todayDate){
          Swal("No Rooms Available");
        }
    },
      error => {
        console.log(error);
      });
    
  }
  Logout() {
    localStorage.removeItem('userToken');
    this.router.navigate(['/Home']);
  }

}
