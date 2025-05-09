import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  apiURL: string = "https://localhost:44357/api/Balanceos";

  constructor(private http:HttpClient) { }

  public save(data:any): Observable<any>{
    return this.http.post(this.apiURL, data);

  }
}
