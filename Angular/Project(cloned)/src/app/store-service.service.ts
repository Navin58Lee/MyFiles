import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Store } from "src/app/store.model";
import { HttpHeaders } from "@angular/common/http";
import { ConfirmBooking } from "src/app/shared/confirm-booking.model";

@Injectable({
  providedIn: 'root'
})
export class StoreServiceService {
  selectedStore :Store= new Store;
  storeList : Store[];
  constructor(private httpClient : HttpClient ) { }
  booking:ConfirmBooking;
  store:Store
// GetSearchs() 
// {
// // return this.httpClient.get<Array<Store>>('http://localhost:57842/api/SearchStores');
// return this.httpClient.get<Array<Store>>('http://localhost:57842/api/SearchStores').toPromise().then(x => this.storeList=x);
// }
Searching(strnew : Store) : Observable<Array<Store>>
{
  // var body = JSON.stringify(strnew);

  // let headers = new HttpHeaders().set('Content-Type', 'application/json');

  // return this.httpClient.put<Array<Store>>('http://localhost:57447/api/BookMyRoom', body, {
  //   headers: headers
  // });
  return this.httpClient.put<Array<Store>>('http://localhost:57447/api/BookMyRoom',strnew);

}
Confirmbooking(obj:ConfirmBooking)
{
 return this.httpClient.post("http://localhost:57447/api/BookMyRoom",obj);
}
}