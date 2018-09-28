import { Component, OnInit } from '@angular/core';
import {EmployeeService} from '../employee.service';
import {Observable} from 'rxjs/Observable';

@Component({
  selector: 'app-employeedetail',
  templateUrl: './employeedetail.component.html',
  styleUrls: ['./employeedetail.component.css']
})
export class EmployeedetailComponent implements OnInit {
 public employees = [];
  constructor(private _employeeService : EmployeeService) { }

  ngOnInit() {
    this._employeeService.getEmployees();
    .subscribe(data => this.employees = data);
  }

}
