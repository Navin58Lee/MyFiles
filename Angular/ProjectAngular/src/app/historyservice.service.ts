import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { History } from "src/app/shared/history.model"
@Injectable({
  providedIn: 'root'
})
export class HistoryserviceService {
  historyList: History[];
  constructor(private httpClient: HttpClient) { }
  booking(book: History){
    return this.httpClient.put<Array<History>>('http://localhost:57447/api/BookingHistory',book);
  }
}
