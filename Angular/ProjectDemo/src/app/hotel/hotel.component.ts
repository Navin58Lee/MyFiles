import { Component, OnInit } from '@angular/core';
import { HotelService } from '../hotel.service';
import { NgForm } from '@angular/forms';
import { Hotel } from '../hotelmodel';
@Component({
  selector: 'app-hotel',
  templateUrl: './hotel.component.html',
  styleUrls: ['./hotel.component.css']
})
export class HotelComponent implements OnInit {
  hotel : Hotel = new Hotel();
  constructor(private hotelService: HotelService) { }
  // receivedData: Array<Hotel> = new Array<Hotel>();
  searchData: Array<Hotel>;
  errormsg : string;
  ngOnInit() {
    this.resetForm();
  }
  resetForm(form? : NgForm)
  {
    if(form !=null)
      form.reset();
      this.hotelService.selectedHotel = {
      Hotel_Id: null, 
      Hotel_Name: '',
      City: '',
      Room_Type: '',
      Price: null,
      Check_In: '',
      Check_Out: ''
    }
  }
  OnSubmit(form : NgForm)
  {
    if(form.value.Hotel_Id == null){
    this.hotelService.postHotel(form.value).subscribe(data =>{
      // this.hotelService.getHotelList();
      this.resetForm(form);
      // this.hotelService.getHotelList();
      alert("New Record Added Successfully");
    } );
  }
  }
  show()
  {
    this.hotelService.searchHotel(this.hotel).subscribe( data =>{
      this.searchData = data;
    });
    // if(this.searchData==null)
    //   {
    //     this.errormsg="No rooms available";
    //   }
    // error =>{
    //   console.log(error);
    // });
    // console.log(JSON.stringify(this.htl));
  }
  // onSubmit(form: NgForm){
  //   console.log(form.value);
  //   this.hotelService.postHotel(form.value).subscribe( data => {
  //   this.receivedData = data;
  //   },
  // error =>{

  // });
  // } 
}
