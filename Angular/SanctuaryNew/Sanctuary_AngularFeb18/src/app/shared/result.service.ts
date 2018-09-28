import { Injectable } from '@angular/core';
import { IUser } from '../dashboard/User';
import { Observable } from 'rxjs/Observable';
import { HttpClient } from '@angular/common/http';
import 'rxjs/add/operator/catch'
import { HttpErrorResponse } from '@angular/common/http/src/response';
import { OperationalResult } from './OperationResult';
import {BehaviorSubject} from 'rxjs/BehaviorSubject';
import { EventEmitter } from '@angular/core';
import { Output } from '@angular/core';

@Injectable()
export class ResultService {

  userResult: OperationalResult
  constructor() { }
 
  @Output() sourceResult:EventEmitter<OperationalResult>=new EventEmitter();

  emitChange(result){
    this.userResult = result;
    this.sourceResult.emit(this.userResult);
  }

  getChange(){
    return this.sourceResult;
  }
}
