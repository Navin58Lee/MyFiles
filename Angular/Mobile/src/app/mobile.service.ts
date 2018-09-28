import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IMobile } from './mobileinterface';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class MobileService{
  private url:string ="assets/data/list.json";
  constructor(private http : HttpClient) { }
  getMobiles(): Observable <IMobile[]>{
    return this.http.get<IMobile[]>(this.url);
  }
}
