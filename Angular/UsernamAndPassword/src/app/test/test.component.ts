import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {
  public a = "";
  public b = "";
  public uname = "";
  public pswd = "";  

  constructor() { }

  ngOnInit() {
  }
  onClick(x,y)
  {
    this.a = "Your name is ";
    this.b = " and your password is ";
    this.uname = x;
    this.pswd = y;
  }
}
