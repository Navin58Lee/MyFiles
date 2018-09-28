import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Hotel } from './hotelmodel';
import { HttpHeaders } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class HotelService {
  selectedHotel: Hotel;
  hotelList : Hotel[];

  constructor(private http : HttpClient) { }
  postHotel(hotel : Hotel)
  {
    return this.http.post('http://localhost:50270/api/Hotels',hotel)
  }
  // getHotelList(){
  //   return this.http.get('http://localhost:50270/api/Hotels').pipe(map((data : Response) =>{
  //      return data.json() as Hotel[];
  //    })).subscribe(x => {
  //      this.hotelList = x;
  //    })
  //  }
   searchHotel(hotelsearch: Hotel) : Observable<Array<Hotel>>{
     var body = JSON.stringify(hotelsearch);
     let headers = new HttpHeaders().set('Content-Type', 'application/json');
     return this.http.put<Array<Hotel>>('http://localhost:50270/api/Hotels',body,{headers: headers});
   }
  }