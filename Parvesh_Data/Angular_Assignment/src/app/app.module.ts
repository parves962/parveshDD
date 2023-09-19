import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { TeacherLoginComponent } from './teacher-login/teacher-login.component';
import { StudentLoginComponent } from './student-login/student-login.component';
import { StudentRecordComponent } from './student-record/student-record.component';
import { StudentResultComponent } from './student-result/student-result.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HeaderComponent } from './header/header.component';
import { AddRecordComponent } from './add-record/add-record.component';
import {ReactiveFormsModule} from '@angular/forms';
import { UpdateComponent } from './update/update.component';
import { HomePageComponent } from './home-page/home-page.component';

@NgModule({
  declarations: [
    AppComponent,
    
    TeacherLoginComponent,
    StudentLoginComponent,
    StudentRecordComponent,
    StudentResultComponent,
    HeaderComponent,
    AddRecordComponent,
    UpdateComponent,
    HomePageComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
