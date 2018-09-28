import { Component, OnInit } from '@angular/core';
import { UserService } from '../shared/user.service';
import { NgForm } from '@angular/forms';
@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  constructor(private userService : UserService) { }

  ngOnInit() {
    this.resetForm();
  }
  resetForm(form? : NgForm)
{
  if(form !=null)
    form.reset();
    this.userService.selectedUser = {
    User_Id: null, 
    Firstname: '',
    Lastname: '',
    Password: '',
    Gender: '',
    Email: '',
    Mobile: ''
  }
}
OnSubmit(form : NgForm)
{
  if(form.value.User_Id == null){
  this.userService.postUser(form.value).subscribe(data =>{
    this.userService.getUserList();
    this.resetForm(form);
    this.userService.getUserList();
    alert("New Record Added Successfully");
  } );
}
else{
  this.userService.putUser(form.value.User_Id, form.value).subscribe(data => {
    this.resetForm(form);
    this.userService.getUserList();
    alert("Record Updated Successfully")
  });
}
}
clickCheckbox(id: number){
      this.userService.getUserList1(id);
}
}
