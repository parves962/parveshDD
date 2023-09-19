import { Component } from '@angular/core';
import {ActivatedRoute,Route,Router} from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngularAssignment';
  constructor(private route: Router) { }


  click1()
  {
    this.route.navigate(['/teacher-login']);
  }

  click2()
  {
    this.route.navigate(['/student-login']);
  }
}
