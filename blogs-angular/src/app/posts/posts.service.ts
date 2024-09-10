import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Posts } from './posts';
import { ConfigService } from '../config.service';

@Injectable({
  providedIn: 'root'
})
export class PostsService {

  constructor(private http: HttpClient, private configService: ConfigService) { }

  get() {
    return this.http.get<Posts[]>(this.configService.domain +'api/Post/GetPost');
  }
  create(payload: Posts) {
    return this.http.post<Posts>(this.configService.domain +'api/Post/AddPost', payload);
  }

  getById(id: number) {
    return this.http.get<Posts>(this.configService.domain +`api/Post/GetPostById?id=${id}`);
  }
  getListPostByUserId(id: string) {
    return this.http.get<Posts[]>(this.configService.domain +`api/Post/GetListPostByUserId?id=${id}`);
  }
  update(payload:Posts){
    return this.http.put(this.configService.domain +`api/Post/UpdatePost/`,payload);
  }
  
  delete(id:number){
    // return this.http.delete<Posts>(`http://localhost:3001/Posts/${id}`);

    const url = this.configService.domain +`api/Post/DeletePost?id=${id}`;
    return this.http.delete(url);
 }
 

 getByCategory(category: string) {
  return this.http.get<Posts[]>(`http://localhost:3001/Posts/${category}`);
}

} 
 