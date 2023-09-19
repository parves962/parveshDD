import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class ResultService {

  constructor(private http:HttpClient) { }
  
  url = "http://localhost:3000/studentRecord";
  
  getData()
  {
    return this.http.get(this.url);
    // return this.http.get<any>(`${this.getApiUrl()}
    // SpecialtyList/Get?slId=${slId}`)
  }

  

  saveData(data:any)
  {
      return this.http.post(this.url,data);
  }

  deleteRecord(id:any)
  {
    return this.http.delete(`${this.url}/${id}`)
  }

  getCurrentRecord(id:any)
  {
    return this.http.get(`${this.url}/${id}`);
  }

  updateRecord(id:any,data:any)
  {
    return this.http.put(`${this.url}/${id}`,data);
  }

  param = {
    name: '',
    rollno : ''
  };
  searchRecord(RollNo:any,Name:any)
  {
    this.param.name = Name;
    this.param.rollno = RollNo;
    return this.http.get(`${this.url}/${this.param}`);
  }

  login(data:any)
  {
    return this.http.get(`http://localhost:3000/studentRecord?RollNo=${data.RollNo}&Name=${data.Name}`)
  }
}
