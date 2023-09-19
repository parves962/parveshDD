import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';
import {ResultService} from '../result.service';
import {ActivatedRoute} from '@angular/router';
import {Router} from '@angular/router';
@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  alert:boolean = false;
  editRecord = new FormGroup({
    RollNo: new FormControl('',Validators.required),
    Name: new FormControl('',Validators.required),
    DOB: new FormControl('',Validators.required),
    Score: new FormControl('',Validators.required)
  })

  constructor(private router:ActivatedRoute,private result:ResultService,private route:Router) { }

  ngOnInit(): void {
      console.warn(this.router.snapshot.params['id']);
      this.result.getCurrentRecord(this.router.snapshot.params['id']).
      subscribe((data:any)=>{
        this.editRecord = new FormGroup({
          RollNo: new FormControl(data['RollNo']),
          Name: new FormControl(data['Name']),
          DOB: new FormControl(data['DOB']),
          Score: new FormControl(data['Score'])
        })
      })
  }

  collection()
  {
    console.warn(this.editRecord.value);
    this.result.updateRecord(this.router.snapshot.params['id'],this.editRecord.value).subscribe((data:any)=>
    console.warn(data)
    
    )
    this.route.navigate(['student-record']);
    this.alert = true;
  }

  closeAlert()
  {
    this.alert = false;
  }
  get RollNo(){return this.editRecord.get('RollNo')};
  get Name(){return this.editRecord.get('Name')};
  get DOB(){return this.editRecord.get('Name')};
  get Score(){return this.editRecord.get('Score')};
}
