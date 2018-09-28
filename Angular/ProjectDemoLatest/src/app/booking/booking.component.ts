import { Component, OnInit } from '@angular/core';
import { HotelsService } from '../hotels.service';
import { NgForm } from '@angular/forms';
import { Dummy } from '../Dummy';
@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent implements OnInit {
  hotel: Dummy = new Dummy();
  constructor(private hotelsService: HotelsService) { }
  bookingData: Array<Dummy>;
  ngOnInit() {
  }
  history() {
    this.hotelsService.searchHotel(this.hotel).subscribe(data => {
      this.bookingData = data;
    });
  }
}
