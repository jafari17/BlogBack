import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Categories } from './categories';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  constructor(private http: HttpClient) { }

  get() {
    return this.http.get<Categories[]>('https://localhost:8081/api/Category/GetCategory');
  }

  create(payload: Categories) {
    return this.http.get<Categories>(`https://localhost:8081/api/Category/AddCategory?TitleCategory=${payload.titleCategory}&DescriptionCategory=${payload.descriptionCategory}` );
  }
  getById(id: number) {
    return this.http.get<Categories>(`http://localhost:3001/Categories/${id}`);
  }
    
  update(payload:Categories){
    return this.http.put(`http://localhost:3001/Categories/${payload.categoryId}`,payload);
  }
  
  delete(id:number){
    console.log("delete(Id:number)");
    console.log(id);
    // return this.http.post<number>(`http://localhost:5109/api/Category/DeleteCategory`, Id );
    // return this.http.get(`http://localhost:5109/api/Category/DeleteCategory/${id} `);

    const url = `https://localhost:8081/api/Category/DeleteCategory?Id=${id}`;
    return this.http.delete(url);

 }
}

