import { Component, OnInit } from '@angular/core';
import {ActivatedRoute,Route,Router} from '@angular/router';
import { FormGroup,FormControl } from '@angular/forms';
import {ResultService} from '../result.service';

@Component({
  selector: 'app-student-result',
  templateUrl: './student-result.component.html',
  styleUrls: ['./student-result.component.css']
})
export class StudentResultComponent implements OnInit {

  constructor(private router:ActivatedRoute,private result:ResultService,private route:Router) { }

  

  result1={
    RollNo:'',
    Name : '',
    DOB : '',
    Score : ''
  }
  
  resultRecord = new FormGroup({
    RollNo: new FormControl(''),
    Name: new FormControl(''),
    DOB: new FormControl(''),
    Score: new FormControl('')
  })

  resultdata:any;
  ngOnInit(): void {
    let id1 = this.router.snapshot.paramMap.get('id1');
    let id2 = this.router.snapshot.paramMap.get('id2');
    let param = {RollNo : id1, Name: id2};

    this.result.login(param).subscribe((data:any)=>{
      console.warn();
      this.resultdata = data;
      
    })
      
  }

  GotoLogin()
  {
    this.route.navigate(['student-login']);
  }
}
