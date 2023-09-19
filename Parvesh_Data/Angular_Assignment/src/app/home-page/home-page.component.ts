import { Component, OnInit } from '@angular/core';
import {ActivatedRoute,Route,Router} from '@angular/router';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {

  constructor(private route: Router) { }

  ngOnInit(): void {
  }

  click1()
  {
    this.route.navigate(['/teacher-login']);
  }

  click2()
  {
    this.route.navigate(['/student-login']);
  }
}
