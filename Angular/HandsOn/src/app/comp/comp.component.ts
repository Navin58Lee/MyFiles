import { Component, OnInit } from '@angular/core';
import { User } from '../model';
@Component({
  selector: 'app-comp',
  templateUrl: './comp.component.html',
  styleUrls: ['./comp.component.css']
})
export class CompComponent implements OnInit {
  constructor() { }
  public array = [];
  ngOnInit() {
  }

  onClick(x,y,z)
  {
   this.array.push
  }
}
