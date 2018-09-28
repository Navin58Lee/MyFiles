import { Injectable } from '@angular/core';
import { Http, Response, Headers,RequestOptions,RequestMethod } from '@angular/http';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { User } from './user.model';
import { HttpHeaders } from "@angular/common/http";
import { vaLogin } from "src/app/shared/login.model";


@Injectable({
  providedIn: 'root'
})
export class UserService {
  SearchUser:User;
  Loggeduser:User;
// rootUrl='https://bookmyroomapidotnet.azurewebsites.net';
readonly rootUrl = 'http://localhost:57447';
  selectedUser : User = {
    Uid:null,
    Name:'',
    UserName:'',
    Email: '',
    Password: '',
    Gender:'',
    Age:null,
    Mobile_no:'',
    RewardPoints:0
  };
  allowedUser : vaLogin={
    UserName:'',
    Password: ''
  };
 
  constructor(private http: HttpClient) { }
  postUser(user : User)
  {
    return this.http.post(this.rootUrl + '/api/UserDetails',user);
    
  }
 
  validate(logindetails:User)
  {
    return this.http.post(this.rootUrl+'/api/UserDetails/Validate',logindetails);
  }
  loggeduser:User;
  LoggedUserDetails()
  { 
          this.loggeduser=JSON.parse(localStorage.getItem('loggingdetails'));
          
      this.http.post(this.rootUrl+'/api/UserDetails/LoggedUser',this.loggeduser).subscribe((x:User)=>{this.Loggeduser=x;
      localStorage.setItem('currentuser', JSON.stringify(x));
      console.log(x);
        });
  }
}