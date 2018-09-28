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
  selectedStore :Store= new Store;
  storeList : Store[];
  constructor(private httpClient : HttpClient ) { }
  booking:ConfirmBooking;
  store:Store
  //https://bookmyroomapidotnet.azurewebsites.net/api/BookMyRoom
Searching(strnew : Store) : Observable<Array<Store>>
{  
  return this.httpClient.put<Array<Store>>('https://bookmyroomapidotnet.azurewebsites.net/api/BookMyRoom',strnew);
}
Confirmbooking(obj:ConfirmBooking)
{
 
 return this.httpClient.post('https://bookmyroomapidotnet.azurewebsites.net/api/BookMyRoom',obj);
 
}
updaterewards(obj:User)
{
 return this.httpClient.post('https://bookmyroomapidotnet.azurewebsites.net/api/UserDetails/UpdateRewards',obj);
}
// BookingHistory(book : Store){
//   return this.httpClient.put<Array<Store>>('https://bookmyroomapidotnet.azurewebsites.net/api/BookMyRoom',book);
// }
}