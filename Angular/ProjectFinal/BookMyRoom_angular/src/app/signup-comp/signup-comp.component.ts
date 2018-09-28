import { Component, OnInit } from '@angular/core';
import { UserService } from '../shared/user.service';
import { NgForm } from '@angular/forms';
import Swal from 'sweetalert2';
import { Router } from "@angular/router";

@Component({
  selector: 'app-signup-comp',
  templateUrl: './signup-comp.component.html',
  styleUrls: ['./signup-comp.component.css'],
  providers:[UserService]
})
export class SignupCompComponent implements OnInit {

  constructor(public userService:UserService,private route:Router) { }
  emailPattern="^[A-Za-z0-9_]+(?:\\.[a-z0-9]+)*@[A-Za-z0-9.-]+\\.[A-Za-z]{2,64}$";
  agePattern="^(1[89]|[2-9][0-9])$";
  genders: string[] ;
  mobPattern="[789][0-9]{9}";
  userPattern="^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])[A-Za-z0-9]{3,15}$"; 
  passwordPattern="((?=.*\\d)(?=.*[a-z])(?=.*[@#$%]).{6,15})";
  fullnamePattern="([A-Za-z]+)\\s*([A-Za-z]+)\\s*([A-Za-z]+)";
  
  ngOnInit() {
    this.resetForm();

  this.genders=[ 'Male', 'Female', 'Others'];

   
  
  }
  resetForm(form? : NgForm)
  {
    if(form != null)
     form.resetForm();
     this.userService.selectedUser={
       userId:null,
      name: '',
      userName:'',
      email: '',
      password: '',
      gender:'',
      age:null,
      mobileNo:'',
      rewardPoints:null
  
     }
   
    }
   
    onSubmit(form :NgForm)
    {
    this.userService.postUser(form.value)
      .subscribe( data =>{
        if(data==1)
          {
          this.resetForm(form);
          this.valid(data);
          }
          else{
            this.valid(data);
          }
        
      });
     
    }
    valid(k)
    {
      if(k!=0)
        {
      Swal({
        title: '<strong>Registration Successful</strong>',
        type: 'info',
        html: '<b> You can now go and Login </b>',
       
        focusConfirm: false,
        confirmButtonText:
          '<i class="fa fa-thumbs-up"></i> OK',
        confirmButtonAriaLabel: 'Thumbs up, great!',
       
        
      }).then((result) => {
        if (result.value) {
         this.route.navigate(['/Home'])
         this.resetForm();
        }
        // else{
        //   this.route.navigate(['/Home'])
        // }
      });
      //this.resetForm();
    }
    else{
      // Swal("Username/email already exists !");
      Swal({
        type: 'error',
        title: 'Oops...',
        text: 'UserName/Email already exists'
    
      })
      
    }
    }
}


