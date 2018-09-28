import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-formschild',
  templateUrl: './formschild.component.html',
  styleUrls: ['./formschild.component.css']
})
export class FormschildComponent implements OnInit {

  constructor() { }
  @Input() public details = [];
  ngOnInit() {
  }

}
