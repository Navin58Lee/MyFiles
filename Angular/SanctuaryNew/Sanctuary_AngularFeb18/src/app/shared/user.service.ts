import { Injectable } from '@angular/core';
import { IUser } from '../dashboard/User';
import { Observable } from 'rxjs/Observable';
import { HttpClient } from '@angular/common/http';
import 'rxjs/add/operator/catch'
import { HttpErrorResponse } from '@angular/common/http/src/response';
import { OperationalResult } from './OperationResult';

@Injectable()
export class UserService
{
    //private userAPI : string = "http://localhost:61938/User";
    private userAPI : string = "http://localhost:61938/User";
    constructor(private http : HttpClient)
    {
        
    }

    getAllUser() : Observable<IUser>
    {
        return this.http.get<IUser>(this.userAPI + "/all");
    }

    getUser(email : string, password : string) : Observable<any>
    {
        return this.http.get<OperationalResult>(this.userAPI + "/login", { params : { email : email, password : password }});
    }

    getUserforgotPassword(email : string) : Observable<OperationalResult>
    {
        return this.http.get<OperationalResult>(this.userAPI + "/forgotPassword", { params : { email : email }});
    }

    getResult() : Observable<OperationalResult>
    {
        return this.http.get<OperationalResult>(this.userAPI);//.catch(this.handleError);
    }
    updateUser(user : IUser) : Observable<OperationalResult>
    {
        let body = user;
        return this.http.put<OperationalResult>(this.userAPI + "/Update", body);
    }
    sendEmail(email:string,key:number) : Observable<any>{

        return this.http.post(this.userAPI + "/sendEmail", { params : { email : email, key : key }});
    }

    saveUser(user : IUser) : Observable<any>
    {
        let body = user;
        return this.http.post(this.userAPI + "/Create" , body);
    }

    deleteUser(id : string) : Observable<any>
    {
        return this.http.delete(this.userAPI + "/delete", { params : { id : id}});
    }

    private handleError(err : HttpErrorResponse)
    {

    }
}