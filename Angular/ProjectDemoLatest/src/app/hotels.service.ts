import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Dummy } from './Dummy';
import { HttpHeaders } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class HotelsService {
  selectedHotel: Dummy;
  hotelList: Dummy[];
  constructor(private http : HttpClient) { }
  postHotel(hotel : Dummy)  
  {
    return this.http.post('http://localhost:56814/api/Hotels',hotel)
  }
  searchHotel(hotelsearch: Dummy) : Observable<Array<Dummy>>{
    var body = JSON.stringify(hotelsearch);
    let headers = new HttpHeaders().set('Content-Type', 'application/json');
    return this.http.put<Array<Dummy>>('http://localhost:56814/api/Hotels',body,{headers: headers});
  }
}