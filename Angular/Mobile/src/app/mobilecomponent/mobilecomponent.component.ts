import { Component, OnInit } from '@angular/core';
import { MobileService } from '../mobile.service';
@Component({
  selector: 'app-mobilecomponent',
  templateUrl: './mobilecomponent.component.html',
  styleUrls: ['./mobilecomponent.component.css']
})
export class MobilecomponentComponent implements OnInit {
 
  public mobiles = [];
  constructor(private mob : MobileService) { }

  ngOnInit() {
  this.mob.getMobiles().subscribe(data =>this.mobiles = data);
}
}
