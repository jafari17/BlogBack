import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
// import { Labels } from './labels';

@Injectable({
  providedIn: 'root'
})
export class LabelsService {

  constructor(private http: HttpClient) { }



//   get() {
//     return this.http.get<Labels[]>('http://localhost:3001/Labels');
//   }
//   create(payload: Labels) {
//     return this.http.post<Labels>('http://localhost:3001/Labels', payload);
//   }

//   getById(id: number) {
//     return this.http.get<Labels>(`http://localhost:3001/Labels/${id}`);
//   }
    
//   update(payload:Labels){
//     return this.http.put(`http://localhost:3001/Labels/${payload.id}`,payload);
//   }
  
//   delete(id:number){
//     return this.http.delete<Labels>(`http://localhost:3001/Labels/${id}`);
//  }
}
