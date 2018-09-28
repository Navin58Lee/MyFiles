import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent implements OnInit {
  public array = [];
  public name;
  public mid;
  public feedback;
  constructor() { }
  ngOnInit() {
  }
  onPost(){
    this.array.push({Name: this.name,Mid : this.mid,Feedback : this.feedback})
  }
 
  
  objDate = Date.now();
  onClear()
  {
    this.name=null;
    this.mid=null;
    this.feedback=null;
  }

}
