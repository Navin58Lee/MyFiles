import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { UserService } from "src/app/shared/user.service";
import Swal from 'sweetalert2';
import { HttpErrorResponse } from "@angular/common/http";
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { User } from "src/app/shared/user.model";
import { NgForm } from "@angular/forms";
import { AuthGuard } from "src/app/auth/auth.guard";
import { ConfirmserviceService } from "src/app/shared/confirmservice.service";


@Component({
  selector: 'app-login-comp',
  templateUrl: './login-comp.component.html',
  styleUrls: ['./login-comp.component.css']
})
export class LoginCompComponent implements OnInit {
  isLoginError: boolean = false;

  constructor(public userService: UserService, private router: Router,private auth: ConfirmserviceService) { }

  ngOnInit() {
    this.resetForm();
    
    
  }
  resetForm(form? : NgForm)
  {
    if(form != null)
     form.resetForm();
  }
  OnSubmit(form:NgForm) {
   
  this.userService.validate(form.value).subscribe(data=>{
    if(data)
      {

        localStorage.setItem('loggingdetails',JSON.stringify(form.value));
        this.userService.LoggedUserDetails();
        this.auth.provide_access(true);
        this.resetForm(form);
       
      
        Swal({
              title: '<strong>Logged in Successfully !</strong>',
              type: 'info',
      
              confirmButtonText:
              '<i class="fa fa-thumbs-up"></i> OK',
              confirmButtonAriaLabel: 'Thumbs up, great!',
      
            })
              .then((result) => {
                if (result.value) {
                 
                  this.router.navigate(['/Search']);
                  document.getElementById("login_modal").style.display="none";
                }
      
              });
      }
      else{ 
        
        Swal({
                  title: '<strong>UserName or Password is Incorrect !</strong>',
                  type: 'warning',
                })
                
               
                
      }
      
  })
   
  }

}