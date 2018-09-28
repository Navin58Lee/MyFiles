import { Component, OnInit } from '@angular/core';
import { Event } from "src/app/Event";
import { EventsService } from "src/app/events.service";
import { NgForm } from '@angular/forms';
import { NgModule } from '@angular/core';
@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit {
  eventsObj: Event = {
    eventId: null,
    eventName: '',
    participantName: ''
  }
  constructor(private eventsService: EventsService) { }
eventList: string[];
displayList: Event[];
enableButton: boolean = false;
  ngOnInit() {
  this.eventList=["Singing","Dancing"];
  }
  resetForm(form?: NgForm){
    form.resetForm();
    this.eventsService.eventListObj= {
      eventId: null,
      eventName: '',
      participantName: ''
    }
  }
  onSubmit(form: NgForm){
    this.eventsService.postEvent(form.value).subscribe((data)=>this.resetForm(form));
  }
  Show(){
    this.eventsService.showEvent().subscribe((x: Event[])=>this.displayList=x);
  }
  function(){
   this.enableButton=true;
  }
}
