import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-test',
  template: `<div>
  <p>Hello there!</p>
  <h2>Good to see ya {{name}}!</h2>
  <p>Your name has {{name.length}} characters</p>
  <p>Your name has been converted to UpperCase</p>
  <p>{{name.toUpperCase()}}</p>
  <p>I am gonna print your name by calling a method</p>
  <p>{{greetUser()}}</p>
  <input bind-id="id" type="text" value="Clay Jensen"><br>


  <button (click)=onClick()>Greet</button>
  <br><br>
  <p>{{greeting}}</p>
  <!--<input [(ngModel)]="username" type="text">
  {{username}}
  <br>
  <br>
  <input #textbox1 type="text">
  <br><br>
  <input #textbox2 type="text">
  <br>
  <button (click)=onClick1()>Submit</button>
  <br>
  {{UserName}}
  {{password}}-->


  Name    : <input #textbox1 type="text"><br><br>
  Password : <input #textbox2 type="text"><br><br>
  <button (click)="Function(textbox1.value,textbox2.value)">Submit</button>
  <br><br>
  <p>{{a}} {{funVariable}} {{b}} {{anotherFunVariable}}</p>
  </div>`,
  styles: [`div{color : red}`]
})
export class TestComponent implements OnInit {
  public name = "Hannah Baker";
  public id = "Property";
  public greeting = "";
  public username = "";
  public click = "";
  public UserName = "";
  public password = "";
  public funVariable = "";
  public anotherFunVariable = "";
  public a = "";
  public b = "";
  constructor() { }
  ngOnInit() {
  }
  greetUser() {
    return "Hai " + this.name;
  }
  onClick() {
    this.greeting = 'Hey Clay, did you just click that button? ;)'
  }
  onClick1() {
    this.UserName = 'Your name is';
    this.password = 'and your password is';

  }
  Function(x, y) {
    this.a = 'Your name is';
    this.b = " and your password is"
    this.funVariable = x;
    this.anotherFunVariable = y;
  }
}
