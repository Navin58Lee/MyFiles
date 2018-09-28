import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Store } from "src/app/store.model";
import { HttpHeaders } from "@angular/common/http";
import { ConfirmBooking } from "src/app/shared/confirm-booking.model";
import { User } from "src/app/shared/user.model";

@Injectable({
  providedIn: 'root'
})
export class StoreServiceService {
  selectedStore: Store = new Store;
  storeList: Store[];
  constructor(private httpClient: HttpClient) { }
  booking: ConfirmBooking;

  Hoteldetails: Store;
  // rooturl='https://bookmyroomapidotnet.azurewebsites.net';
  readonly rooturl = 'http://localhost:57447';
  Searching(strnew: Store): Observable<Array<Store>> {

    return this.httpClient.put<Array<Store>>(this.rooturl + '/api/BookMyRoom', strnew);

  }
  Confirmbooking(obj: ConfirmBooking) {

    return this.httpClient.post(this.rooturl + '/api/BookMyRoom', obj);

  }
  updaterewards(obj: User) {
    return this.httpClient.post(this.rooturl + '/api/UserDetails/UpdateRewards', obj);
  }
}