import { Component, OnInit } from '@angular/core';
import {ResultService} from '../result.service'; 
import { FormGroup,FormControl,Validators } from '@angular/forms';
import {ActivatedRoute,Route,Router,} from '@angular/router';

@Component({
  selector: 'app-teacher-login',
  templateUrl: './teacher-login.component.html',
  styleUrls: ['./teacher-login.component.css']
})
export class TeacherLoginComponent implements OnInit {

  constructor(private result:ResultService,private route:Router) { }
 res:any = {
  RollNo: '',
  Name: '',
  DOB: '',
  SCore: ''
 };

 
  ngOnInit(): void {
    this.result.getData().subscribe(data=>{
      console.warn(data);
      this.res = data;
    })
  }

  loginTeacher= new FormGroup({
    name: new FormControl('',Validators.required),
    password: new FormControl('',[Validators.required,Validators.minLength(4)])
  })
    
  login={
    name: 'Ashish Sharma',
    password: 'Ashish@12345'
  }

  collection :any = [];
 

  get name()
  {
    return this.loginTeacher.controls['name'];
  }
  get password()
  {
    return this.loginTeacher.controls['password'];
  }
  check(data: any){
       this.collection = data;
       if(this.login.name == data.name && this.login.password == data.password)
      {
        
        this.route.navigate(['student-record']);
      }
      else{
        alert("Invalid Credentials");
        this.loginTeacher.reset();
      }
  }

  
}
