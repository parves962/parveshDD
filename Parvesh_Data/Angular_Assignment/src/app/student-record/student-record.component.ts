import { Component, OnInit } from '@angular/core';
import {ResultService} from '../result.service';
import {ActivatedRoute,Route,Router} from '@angular/router';

@Component({
  selector: 'app-student-record',
  templateUrl: './student-record.component.html',
  styleUrls: ['./student-record.component.css']
})
export class StudentRecordComponent implements OnInit {

  constructor(private result:ResultService,private route:Router) { }

  collection:any = [];
  ngOnInit(): void {
    // this.result.getData().subscribe(data=>{
    //   console.warn(data);
    //   this.collection = data;
    // })
    this.getRecord();
  }

  getRecord()
  {
    this.result.getData().subscribe(data=>{
      console.warn(data);
      this.collection = data;
    })
  }

  deleteRecord(item:any)
  {
    this.collection.splice(item-1,1);
    this.result.deleteRecord(item).subscribe((instance)=>
    {
       console.warn("instance",instance)
       this.getRecord();
    })
    //this.route.navigate(['/-record']);
  }

  Addrecord()
  {
    this.route.navigate(['/add-record']);
  }
}
