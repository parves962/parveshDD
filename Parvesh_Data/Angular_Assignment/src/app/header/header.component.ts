import { Component, OnInit } from '@angular/core';
import {ActivatedRoute,Route,Router} from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private route: Router) { }

  ngOnInit(): void {
  }

  logout()
  {
    this.route.navigate(['']);
  }
}
