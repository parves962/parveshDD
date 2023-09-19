import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {TeacherLoginComponent} from './teacher-login/teacher-login.component';
import {StudentLoginComponent} from './student-login/student-login.component';
import {StudentRecordComponent} from './student-record/student-record.component';
import {StudentResultComponent} from './student-result/student-result.component';
import{AddRecordComponent} from './add-record/add-record.component';
import {UpdateComponent} from './update/update.component'
import {HomePageComponent} from './home-page/home-page.component'
const routes: Routes = [
  {
    component: HomePageComponent,
    path : ''
  },
  {
    component:TeacherLoginComponent,
    path:'teacher-login'
  },
  {
    component:StudentLoginComponent,
    path:'student-login'
  },
  {
    component:StudentRecordComponent,
    path:'student-record'
  },
  {
    component:StudentResultComponent,
    path:'student-result/:id1/:id2'
  },
  {
    component:AddRecordComponent,
    path:'add-record'
  },
  {
    component:UpdateComponent,
    path:'update/:id'
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
