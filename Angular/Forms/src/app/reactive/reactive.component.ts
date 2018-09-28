import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-reactive',
  templateUrl: './reactive.component.html',
  styleUrls: ['./reactive.component.css']
})
export class ReactiveComponent implements OnInit {
  ngOnInit() {
  }
  rForm: FormGroup;
  post:any;   
  name:string = '';
  age:'';
  gender: '';
  email:'';
  password:'';
  address:string ='';

 
  titleAlert:string = 'This field is required';
  constructor(private fb: FormBuilder) {
    this.rForm =  fb.group({
      'name': [null, Validators.required],
      'age' : [null, Validators.required],
      'gender':[null,Validators.required],
      'email':[null,[Validators.required,Validators.email]],
      'password':[null,Validators.required],
      // 'feedback': [null, Validators.compose([Validators.required, Validators.minLength(10),Validators.maxLength(100)])],
    });
  }
    addPost(post)
    {
      this.address = post.address;
      this.name = post.name;
      this.age = post.age;
      this.gender  = post.gender;
      this.email = post.email;
      this.password = post.password;
    }

   }

