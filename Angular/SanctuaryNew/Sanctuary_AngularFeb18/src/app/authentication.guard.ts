import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { CanDeactivate } from '@angular/router/src/interfaces';
import { Router} from '@angular/router';

@Injectable()
export class AuthenticationGuard implements CanActivate {
  constructor(private _router:Router) { }
  canActivate(){
    if(localStorage.getItem("status")!=null)
      return true; 
    else
    this._router.navigate(["/"]);
      
  }

  canDeactivate(){
    
  }
}
