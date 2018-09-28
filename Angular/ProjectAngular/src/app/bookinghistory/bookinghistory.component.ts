import { Component, OnInit } from '@angular/core';
import { History } from "src/app/shared/history.model"
import {HistoryserviceService } from "src/app/historyservice.service";
@Component({
  selector: 'app-bookinghistory',
  templateUrl: './bookinghistory.component.html',
  styleUrls: ['./bookinghistory.component.css']
})
export class BookinghistoryComponent implements OnInit {

  constructor(private historyService: HistoryserviceService) { }
  hotelnew: History = new History();
  historyData: Array<History>;
  ngOnInit() {
  }
  hello()
  {
    this.historyService.booking(this.hotelnew).subscribe(data => {
      this.historyData = data;
  });
}
}
