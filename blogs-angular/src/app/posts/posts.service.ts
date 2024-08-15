import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Posts } from './posts';

@Injectable({
  providedIn: 'root'
})
export class PostsService {

  constructor(private http: HttpClient) { }

  get() {
    return this.http.get<Posts[]>('https://localhost:8081/api/Post/GetPost');
  }
  create(payload: Posts) {
    return this.http.post<Posts>('https://localhost:8081/api/Post/AddPost', payload);
  }

  getById(id: number) {
    return this.http.get<Posts>(`https://localhost:8081/api/Post/GetPostById?id=${id}`);
  }
    
  update(payload:Posts){
    return this.http.put(`https://localhost:8081/api/Post/UpdatePost/`,payload);
  }
  
  delete(id:number){
    // return this.http.delete<Posts>(`http://localhost:3001/Posts/${id}`);

    const url = `https://localhost:8081/api/Post/DeletePost?id=${id}`;
    return this.http.delete(url);
 }
 

 getByCategory(category: string) {
  return this.http.get<Posts[]>(`http://localhost:3001/Posts/${category}`);
}

} 

 