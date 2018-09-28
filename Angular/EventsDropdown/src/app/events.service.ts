import { Injectable } from '@angular/core';
import { Event } from "src/app/Event";
import { HttpClient } from "@angular/common/http";
@Injectable({
  providedIn: 'root'
})
export class EventsService {

  constructor(private http: HttpClient) { }

  eventListObj: Event = {
    eventId: null,
    eventName: '',
    participantName: ''
  }
  postEvent(obj: Event) {
    return this.http.post('http://localhost:63706/api/Event/PostDetails',obj);

  }
  showEvent() {
    return this.http.get('http://localhost:63706/api/Event/GetDetails');
  }
}
