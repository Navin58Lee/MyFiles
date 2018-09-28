import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { History } from "src/app/shared/history"
@Injectable({
  providedIn: 'root'
})
export class HistoryserviceService {
  historyList: History[];
  constructor(private httpClient: HttpClient) { }
  booking(id: number) {
    return this.httpClient.get<Array<History>>('http://localhost:57447/api/BookingHistory/'+id);
  }
  cancel(bid: any): Observable<any>{
   return this.httpClient.delete('http://localhost:57447/api/CancelBooking/CancelBooking',{ params: {bookingId:bid} });
  }
}

// cancelBooking(bookingId: any): Observable<any> {
//   return this.http.delete(this.bookingAPI + "/cancel", { params: { bookingId: bookingId } }).catch(this.handleError);
//   } 