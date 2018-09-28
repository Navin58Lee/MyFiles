import { Component, OnInit } from '@angular/core';
import { HotelsService } from '../hotels.service';
import { NgForm } from '@angular/forms';
import { Dummy } from '../Dummy';
@Component({
  selector: 'app-hotels',
  templateUrl: './hotels.component.html',
  styleUrls: ['./hotels.component.css']
})
export class HotelsComponent implements OnInit {
  hotel: Dummy = new Dummy();
  constructor(private hotelsService: HotelsService) { }
  searchData: Array<Dummy>;
  ngOnInit() {
  }
  show() {
    this.hotelsService.searchHotel(this.hotel).subscribe(data => {
      this.searchData = data;
    });
  }
}