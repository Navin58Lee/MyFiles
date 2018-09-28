import { Component, OnInit } from '@angular/core';
import { Example } from "src/app/Example";
import { ExamplesService } from "src/app/examples.service";
import { NgForm } from '@angular/forms';
import { NgModule } from '@angular/core';
@Component({
  selector: 'app-example',
  templateUrl: './example.component.html',
  styleUrls: ['./example.component.css']
})
export class ExampleComponent implements OnInit {

  constructor(private exampleService: ExamplesService) { }
  exampleObj: Example = {
    eid: null,
    name: '',
    location: ''
  }
  buttonClick: boolean = false;
  somethingElse: Example[];
  ngOnInit() {
  // this.onShow();
  this.exampleService.showExample().subscribe((x: Example[])=> this.somethingElse=x)
  }
  resetForm(form?: NgForm) {
    if (form != null) {
      form.resetForm();
      this.exampleService.something = {
        eid: null,
        name: '',
        location: ''
      }
    }
  }
  submitForm(form: NgForm) {
    this.exampleService.postExample(form.value).subscribe((data) => this.resetForm(form));
    // this.exampleService.postExample(form.value).subscribe();
  }
  onShow()
  {
    this.buttonClick=true;
  }
}
