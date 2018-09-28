import { Component, OnInit } from '@angular/core';
import { Store } from "src/app/store.model";
import { StoreServiceService } from "src/app/store-service.service";
import { NgForm } from "@angular/forms";


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  str : Store =new Store();
  constructor(private storeServiceService:StoreServiceService) { }
  recievedData : Array<Store> = new Array<Store>();
  searchData :  Array<Store>;
  num : number;
  public todayDate : string = (new Date()).toISOString().split("T")[0];
  public tomorrowDate : string = new Date(new Date().getTime() + 86400000).toISOString().split("T")[0];
  errormsg:string;
  stored : Store=new Store();
  search1 : Array<Store> = new  Array<Store>();
  
  ngOnInit() {
    this.str.hotelCity = "Bhubaneswar";
     this.str.hotelToDate = this.tomorrowDate;
    this.str.hotelFromDate = this.todayDate;
    this.str.hotelRoomType="Single";
   // this.storeServiceService.GetSearchs();
  //   .subscribe( data =>{
  //     this.search1=data;
  //   },
  // error => {

  // });
  }
  show(form:NgForm)
  {
   
    //  this.num= this.searchData.length;
    this.storeServiceService.Searching(form.value).subscribe( data =>{
      this.searchData = data;
     console.log(data);
     console.log(this.searchData);
    },
  error => {
    console.log(error);
  });
    if(this.searchData==null)
      {
        this.errormsg="no rooms are available";
      }
   }

}
