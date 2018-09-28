import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-dashboard-comp',
  templateUrl: './dashboard-comp.component.html',
  styleUrls: ['./dashboard-comp.component.css']
})
export class DashboardCompComponent implements OnInit {

  constructor(private router: Router, private route: ActivatedRoute) { }
  //check: boolean = false;
  ngOnInit() {
  }
 openLogin(){
    document.getElementById("login_modal").style.display="block";
  }
}
