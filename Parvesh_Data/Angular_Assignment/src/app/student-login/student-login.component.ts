import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';
import {ResultService} from '../result.service';
import {ActivatedRoute,Route,Router} from '@angular/router';
import{HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-student-login',
  templateUrl: './student-login.component.html',
  styleUrls: ['./student-login.component.css']
})
export class StudentLoginComponent implements OnInit {

  constructor(private service: ResultService,private route:Router,private result : ResultService,private http:HttpClient) { }

  res:any;

   loginStudent= new FormGroup({
    RollNo: new FormControl('',Validators.required),
    Name: new FormControl('',Validators.required)
  });
   collection:any=[];
  ngOnInit(): void {
  }
  
  

   login( param:any)
   {
    this.result.login(param).subscribe((data:any)=>{
      
      this.res = data;
      console.warn(this.res.length);
      
      if(this.res.length && this.res[0].RollNo == param.RollNo && this.res[0].Name == param.Name)
      {

        this.route.navigate(['student-result',param.RollNo,param.Name]);
        
      } 
      else{
        alert("Invalid credentials")
        this.loginStudent.reset();
      }
    }

    
    )
   }
   get RollNo(){return this.loginStudent.get('RollNo')};
  get Name(){return this.loginStudent.get('Name')};

  
   clear()
   {
    this.loginStudent.reset();
   }
}
