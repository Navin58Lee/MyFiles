import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { History } from "src/app/shared/history.modal";
@Injectable({
  providedIn: 'root'
})
export class HistoryserviceService {

  constructor(private httpClient: HttpClient) { }
  booking(id: number) {
    return this.httpClient.get<Array<History>>('http://localhost:57447/api/BookingHistory/'+id);
  }
}
