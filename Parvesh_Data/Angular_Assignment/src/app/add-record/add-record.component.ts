import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';
import {ResultService} from '../result.service';

import {ActivatedRoute,Route,Router} from '@angular/router';
@Component({
  selector: 'app-add-record',
  templateUrl: './add-record.component.html',
  styleUrls: ['./add-record.component.css']
})
export class AddRecordComponent implements OnInit {

  addRecord = new FormGroup({
    RollNo: new FormControl('',Validators.required),
    Name: new FormControl('',Validators.required),
    DOB: new FormControl('',Validators.required),
    Score: new FormControl('',Validators.required)
  })

  
  constructor(private result:ResultService,private route:Router) { }

  ngOnInit(): void {
  }

  alert:boolean = false;
  collectRecord()
  {
    this.result.saveData(this.addRecord.value).subscribe((data)=>{
      this.alert = true;
      
      this.route.navigate(['student-record']);
    });
    
  }

  closeAlert()
  {
    this.alert= false;
  }

  clear()
  {
    this.addRecord.reset();
  }

  get RollNo(){return this.addRecord.get('RollNo')};
  get Name(){return this.addRecord.get('Name')};
  get DOB(){return this.addRecord.get('Name')};
  get Score(){return this.addRecord.get('Score')};
}
