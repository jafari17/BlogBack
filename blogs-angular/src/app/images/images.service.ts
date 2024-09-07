import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ImagesService {

  constructor(private http: HttpClient) { }

  uploudPost(fromData: any) {
    return this.http.post('https://localhost:8081/Image/UploadImage', fromData)
  };

  getByUrl(uuid:string, id: string   ) {
    return this.http.get(`https://localhost:8081/Image/GetImage?randomUUID=${uuid}&Filename=${id}`, {
      responseType: 'text',
    });
  }


 
  getListImage(uuid:string) {
    console.log("getListImage")
    console.log(uuid)
    return this.http.get<any>(`https://localhost:8081/Image/GetListImage?postDirectory=${uuid}`);
  }



  uploudTest() {
    return this.http.post('https://localhost:8081/Image/UploadTest', {
      responseType: 'text',
    });
  };









}
