import { Component, OnInit } from '@angular/core';
import { History } from "src/app/shared/history.modal";
import { HistoryserviceService } from "src/app/historyservice.service";
import { UserService } from "src/app/shared/user.service";
@Component({
  selector: 'app-bookinghistory',
  templateUrl: './bookinghistory.component.html',
  styleUrls: ['./bookinghistory.component.css']
})
export class BookinghistoryComponent implements OnInit {

  constructor(private historyService: HistoryserviceService, private userService: UserService) { }
  hotelnew: History = new History();
  historyData: Array<History>;
  public todayDate: string = (new Date()).toISOString().split("T")[0];
  ngOnInit() {
  }
  hello(){
    this.historyService.booking(this.userService.Loggeduser.userId).subscribe(data => {
      this.historyData = data;
  });
}
}
