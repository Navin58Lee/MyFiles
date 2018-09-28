import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-feedback-comments',
  templateUrl: './feedback-comments.component.html',
  styleUrls: ['./feedback-comments.component.css']
})
export class FeedbackCommentsComponent implements OnInit {
  public t = "";
  constructor() { }

  ngOnInit() {
  }
  onPost(x) {
    this.t = x;
  }
}
