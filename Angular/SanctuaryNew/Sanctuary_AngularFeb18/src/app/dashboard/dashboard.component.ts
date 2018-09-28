import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { UserService } from '../shared/user.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ResultService } from '../shared/result.service';
import { OperationalResult } from '../shared/OperationResult';
import { IUser } from './User'
import { Router } from '@angular/router';
import { Message } from '@angular/compiler/src/i18n/i18n_ast';
import swal from 'sweetalert2';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styles: []
})
export class DashboardComponent implements OnInit {


  constructor(private _result: ResultService, private _router: Router, private userService: UserService) { }

  userData: OperationalResult;
  status: string;
  login: boolean = false;

  public loginForm = new FormGroup({
    emailId: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required])
  });
  public forgotPasswordForm = new FormGroup({
    forgotUserAccountEmail: new FormControl('', [Validators.required, Validators.email])
  });


  ngOnInit() {
    if (localStorage.getItem("status") == "true") {
      this.login = true;
    }
  }

  private user: IUser;
  userForm = new FormGroup({
    firstName: new FormControl('', [Validators.required, Validators.pattern("[A-Z]{1}[a-zA-Z]*(?:(?:\. |[' ])[a-zA-Z]+)*"), Validators.maxLength(20)]),
    lastName: new FormControl('', [Validators.required, Validators.pattern("[A-Z]{1}[a-zA-Z]*(?:(?:\. |[' ])[a-zA-Z]+)*"), Validators.maxLength(20)]),
    email: new FormControl('', [Validators.required, Validators.email, Validators.pattern('^[a-zA-Z]+[A-Za-z0-9._]*@[a-zA-Z]+[.][a-zA-Z]+$')]),
    phoneNumber: new FormControl('', [Validators.required, Validators.pattern('^[1-9][0-9]{9}$')]),
    companyName: new FormControl('', [Validators.required, Validators.pattern("^[A-Za-z0-9]{1}([a-zA-Z0-9]|[- @\\.#&!'])*$")]),
    password: new FormControl('', [Validators.required, Validators.pattern("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&_*])(?=\\S+$).{8,}$"), Validators.minLength(8), Validators.maxLength(20)]),
    confirmPassword: new FormControl('', [Validators.required]),
    securityQuestion: new FormControl('', Validators.required),
    securityAnswer: new FormControl('', [Validators.required, Validators.pattern("^[A-Za-z0-9]{1}([a-zA-Z0-9]|[-\\s@.&!'])*$")])

  }, this.passwordMatchValidator)

  passwordMatchValidator(g: FormGroup) {
    // return g.get('password').value === g.get('confirmPassword').value
    //   ? null : { 
    // return g.get('password').value===g.get('confirmPassword').value
    // ?null:{'mismatch':true}

    if (g.get('password').value === g.get('confirmPassword').value) {
      g.get('confirmPassword').setErrors(null);
      return null;
    }
    else
      g.get('confirmPassword').setErrors({ 'mismatch': true })


  }

  result: OperationalResult = {
    Status: false,
    Message: "",
    Result: null,
    StatusCode: null
  };
  showForgetPasswordForm: boolean = false;

  forgetPassword() {
    this.showForgetPasswordForm = !this.showForgetPasswordForm;
  }
  closeForgetPassword() {
    if (this.showForgetPasswordForm == true) {
      this.showForgetPasswordForm = false;
    }
    this.result.Status = false;
    this.result.Result = null;
    this.result.StatusCode = null;
    this.result.Message = "";
    this.loginForm.reset();
    this.forgotPasswordForm.reset();
    this.userForm.reset();

  }

  emailSend(forgotPasswordForm) {
    let email = forgotPasswordForm.value.forgotUserAccountEmail;
    console.log(email);
    this.userService.sendEmail(email, 1).subscribe(
      data => {
        this.result = data.valueOf();
        if (this.result.Status) {
          swal("Password has been sent to " + email);
        }
        else {
          swal(email+ " not registered.");
        }
      }
    );
  }

    logout(){
     // localStorage.removeItem("status");
     localStorage.clear();
      this.login = false;
      this._router.navigate(["/"]);
    }

    loginUser(loginForm)
    {

      let email = loginForm.value.emailId;
      let password = loginForm.value.password;
      this.userService.getUser(email, password).subscribe(
        data => {
          this.result = data.valueOf();
          if (this.result.Status) {
            debugger;
            localStorage.setItem("status", this.result.Status.toString());
            localStorage.setItem("email",this.result.Result.Email.toString());
            localStorage.setItem("userid",this.result.Result.User_Id.toString());
          }
          if (this.result.Status == true) {
            this._router.navigate(["booking"]);
            window.location.reload();
          }
        }
      );
    }

    saveUser(userForm): void {
      this.user = new IUser();
      this.user.CompanyName = userForm.value.companyName;
      this.user.Email = userForm.value.email;
      this.user.FirstName = userForm.value.firstName;
      this.user.LastName = userForm.value.lastName;
      this.user.Password = userForm.value.password;
      this.user.PhoneNumber = userForm.value.phoneNumber;
      this.user.SecurityQuestion = userForm.value.securityQuestion;
      this.user.SecurityQuestionAnswer = userForm.value.securityAnswer;
      console.log(this.user);

      this.userService.saveUser(this.user).subscribe(
        data => {
          this.result = data.valueOf();
          console.log(this.result);

          if (this.result.Status) {

            localStorage.setItem("status", this.result.Status.toString());
          }

          if (this.result.Status == true) {
            this._router.navigate(["booking"]);
            window.location.reload();
          }
        }
      );
    }
  }
