import { Component, OnInit } from '@angular/core';
import { Console } from '@angular/core/src/console';
import { NgForm } from '@angular/forms/src/directives/ng_form';
import { UserService } from '../shared/user.service';
import { IUser } from '../Dashboard/User';
import { Router} from '@angular/router';
import { Route } from '@angular/compiler/src/core';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  user: IUser;

  constructor(private _userServce: UserService, private _router:Router) { }

  firstName: string;
  lastName: string;
  email: string = localStorage.getItem("email");
  phone: number;
  companyName: string;
  oldPassword: string;
  newPassword: string;
  confirmPassword: string;

  ngOnInit() {
    let emailId = localStorage.getItem("email");

    this._userServce.getUserforgotPassword(emailId).subscribe(
      data => {
        this.user = data.Result;//this.user=data.result
        localStorage.setItem("user", JSON.stringify(this.user));
        this.firstName = JSON.parse(localStorage.getItem("user")).FirstName;//since attribute of user object
        this.lastName = JSON.parse(localStorage.getItem("user")).LastName;
        this.companyName = JSON.parse(localStorage.getItem("user")).CompanyName;
        this.phone = JSON.parse(localStorage.getItem("user")).PhoneNumber;
        this.oldPassword = JSON.parse(localStorage.getItem("user")).Password;
      }
    );
  }


  isSelected: boolean = false;
  check: boolean = true;
  compare: boolean = false;

  OnButtonClick(): boolean {
    this.isSelected = !this.isSelected;
    //this.check=true;
    return false; //since page was getting redirected after clicking submit
  }
  onSubmit(form: NgForm) {
    console.log(form.value);

    this.user.FirstName= document.forms["myForm"]["FirstName"].value;
    this.user.LastName= document.forms["myForm"]["LastName"].value;
    this.user.CompanyName= document.forms["myForm"]["Company"].value;
    this.user.PhoneNumber= document.forms["myForm"]["Phone"].value;
    
    if (this.isSelected==true) {

      var tempOldPassword = document.forms["myForm"]["OldPassword"].value;
      var tempNewPassword = document.forms["myForm"]["NewPassword"].value;
      var tempConfirmPassword = document.forms["myForm"]["ConfirmPassword"].value;

      if(tempNewPassword == tempConfirmPassword && tempOldPassword == this.oldPassword)
      {
      this.user.Password= document.forms["myForm"]["ConfirmPassword"].value;
      this._userServce.updateUser(this.user).subscribe(
        data => {
          this.user = data.Result;
        }

      );
      localStorage.clear();
      this._router.navigate(["/"]);
      window.location.reload();
      

    }
    if(tempOldPassword!=this.oldPassword)
    {
      this.compare=true;
    }
    else
    {
      this.compare=false;
      this.check = false;
    }
  }
    else
    {
      this._userServce.updateUser(this.user).subscribe(
        data => {
          this.user = data.Result;
        }

      );
      this._router.navigate(["/"]);
    }

  }

}
