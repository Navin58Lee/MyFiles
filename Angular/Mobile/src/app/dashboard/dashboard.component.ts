import { Component,OnInit } from '@angular/core';
import { MobileService } from '../mobile.service';
import { map } from 'rxjs/operators';
import { Breakpoints, BreakpointState, BreakpointObserver } from '@angular/cdk/layout';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  /** Based on the screen size, switch from standard to one column per row */
  // cards = this.breakpointObserver.observe(Breakpoints.Handset).pipe(
  //   map(({ matches }) => {
  //     if (matches) {
  //       return [
  //         { title: 'Apple IPhone X(Black,64GB)', cols: 1, rows: 1,path:"assets/iphonex.jpg",display: ' 5.8 inch HD',battery: '4000mAh',price:"Rs.89,999" },
  //         { title: 'Apple IPhone X(Black,64GB)', cols: 1, rows: 1,path:"assets/iphone6s.jpeg",display: ' 5.5 inch HD',battery: '3500mAh',price:"Rs.37,999" },   
  //         { title: 'Samsung Galaxy A6+(Blue, 64GB)', cols: 1, rows: 1,path:"assets/samsunggalaxya6+.jpeg",display: "6 inch HD",battery: "3500mAh",price: "Rs.23,990"},
  //         { title: 'Samsung Galaxy Note 9(Ocean Blue, 512GB)', cols: 1, rows: 1,path:"assets/samsunggalaxynote9.jpeg",display: ' 6.4 inch HD',battery: '3500mAh',price:"Rs.84,900" }, 
  //         { title: 'HTC U11+ (Amazing Silver, 128 GB)', cols: 1, rows: 1,path:"assets/htcu11+.jpeg",display: ' 6 inch HD',battery: '3930mAh',price:"Rs.56,990" }, 
  //         { title: 'Sony Xperia XZ2 (Liquid Black, 64GB)', cols: 1, rows: 1,path:"assets/sonyxperiaxz2.jpeg",display: ' 5.7 inch HD',battery: '3180mAh',price:"Rs.72,990" }, 
  //         { title: 'Sony Xperia Z5 (Gold, 32GB)', cols: 1, rows: 1,path:"assets/sonyxperiaz5.jpeg",display: ' 5.5 inch HD',battery: '3430mAh',price:"Rs.37,999" }, 
  //         { title: 'Nokia 8 (Polished Blue, 64 GB)', cols: 1, rows: 1,path:"assets/nokia8.jpeg",display: ' 5.3 inch HD',battery: '3090mAh',price:"Rs.35,999" }
  //       ];
  //     }
      // return [
      //   { title: 'Apple IPhone X(Black,64GB)', cols: 1, rows: 1,path:"assets/iphonex.jpg",display: ' 5.8 inch HD',battery: '4000mAh',price:"Rs.89,999" },
      //   { title: 'Apple IPhone X(Black,64GB)', cols: 1, rows: 1,path:"assets/iphone6s.jpeg",display: ' 5.5 inch HD',battery: '3500mAh',price:"Rs.37,999" },
      //   { title: 'Samsung Galaxy A6+(Blue, 64GB)', cols: 1, rows: 1,path:"assets/samsunggalaxya6+.jpeg",display: "6 inch HD",battery: "3500mAh",price: "Rs.23,990"},
      //   { title: 'Samsung Galaxy Note 9(Ocean Blue, 512GB)', cols: 1, rows: 1,path:"assets/samsunggalaxynote9.jpeg",display: "6.4 inch HD",battery: '4000mAh',price:"Rs.84,900" },
      //   { title: 'HTC U11+ (Amazing Silver, 128 GB)', cols: 1, rows: 1,path:"assets/htcu11+.jpeg",display: ' 6 inch HD',battery: '3930mAh',price:"Rs.56,990" },
      //   { title: 'Sony Xperia XZ2 (Liquid Black, 64 GB)', cols: 1, rows: 1,path:"assets/sonyxperiaxz2.jpeg",display: ' 5.7 inch HD',battery: '3180mAh',price:"Rs.72,990" },
      //   { title: 'Sony Xperia Z5 (Gold, 32GB)', cols: 1, rows: 1,path:"assets/sonyxperiaz5.jpeg",display: ' 5.5 inch HD',battery: "3430mAh",price:"Rs.89,999" },
      //   { title: 'Nokia 8 (Polished Blue, 64 GB)', cols: 1, rows: 1,path:"assets/nokia8.jpeg",display: ' 5.3 inch HD',battery: '3090mAh',price:"Rs.35,999" }
      // ];
  //   })
  // );
  constructor(private mob: MobileService) {}
  // ngOnit(){
  //   this.mob.getMobiles().subscribe(data => this.mobiles = data);
  // }

  public mobiles = [];
  ngOnInit() {
  this.mob.getMobiles().subscribe(data =>this.mobiles = data);
}
} 
// export class MobilecomponentComponent implements OnInit {
  
//    public mobiles = [];
//    constructor(private mob : MobileService) { }
//    ngOnInit() {
//    this.mob.getMobiles().subscribe(data =>this.mobiles = data);
//  }
//  }
 