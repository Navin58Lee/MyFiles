import { Injectable } from '@angular/core';
import { Example } from "src/app/Example";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ExamplesService {
 
  constructor(private http:HttpClient) { }
  something: Example ={
    eid: null,
    name: '',
    location: ''
  }
  readonly rootUrl='http://localhost:55677';

  postExample(exg: Example){
    return this.http.post(this.rootUrl+'/api/Example/SaveInfo',exg);
}
showExample()
{
  return this.http.get(this.rootUrl+'/api/Example/ShowInfo');
}}