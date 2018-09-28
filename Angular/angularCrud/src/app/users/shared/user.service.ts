import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { User } from './user.model';
// import 'rxjs/add/operator/toPromise';
@Injectable({
  providedIn: 'root'
})
export class UserService {
  selectedUser : User;
  selectedUser2 : User;
  userList : User[];
  constructor(private http : Http) { }
  // postUser(user : User){
  //   var body = JSON.stringify(user);
  //   var headerOptions = new Headers({'Content-Type':'application/json'});
  //   var requestOptions = new RequestOptions({method : RequestMethod.Post,headers : headerOptions});
  //   return this.http.post('http://localhost:50658/api/Users',body,requestOptions).pipe(map(x => x.json()));
  // }
  postUser(user: User)
  {
    return this.http.post('http://localhost:50658/api/Users',user);
  }
  // getUserList(){
  //   this.http.get('http://localhost:50658/api/Users').pipe(map((data : Response) =>{
  //     return data.json() as User[];
  //   })).toPromise().then(x => {
  //     this.userList = x;
  //   })
  // }
  getUserList(){
   return this.http.get('http://localhost:50658/api/Users').pipe(map((data : Response) =>{
      return data.json() as User[];
    })).subscribe(x => {
      this.userList = x;
    })
  }
  getUserList1(id: number){
    this.http.get('http://localhost:50658/api/Users/'+id).pipe(map((data : Response) =>{
      return data.json() as User;
    })).toPromise().then(x => {
      this.selectedUser = x;
    })
  }
  // putUser(id, user){
  //   var body = JSON.stringify(user);
  //   var headerOptions = new Headers({'Content-Type':'application/json'});
  //   var requestOptions = new RequestOptions({method : RequestMethod.Post,headers : headerOptions});
  //   return this.http.post('http://localhost:50658/api/Users/' + id,body,requestOptions).pipe(map(x => x.json()));
  // }
  putUser(id, user)
  {
    return this.http.post('http://localhost:50658/api/Users/' + id,user);
  }
  deleteUser(id){
    return this.http.delete('http://localhost:50658/api/Users/' + id);
  }
}
