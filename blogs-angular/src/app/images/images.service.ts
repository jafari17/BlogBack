import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ConfigService } from '../config.service';

@Injectable({
  providedIn: 'root'
})
export class ImagesService {

  constructor(private http: HttpClient,private configService: ConfigService) { }

  uploudPost(fromData: any) {
    return this.http.post(this.configService.domain +'Image/UploadImage', fromData)
  };

  getByUrl(uuid:string, id: string   ) {
    return this.http.get(this.configService.domain +`Image/GetImage?randomUUID=${uuid}&Filename=${id}`, {
      responseType: 'text',
    });
  }


 
  getListImage(uuid:string) {
    console.log("getListImage")
    console.log(uuid)
    return this.http.get<any>(this.configService.domain +`Image/GetListImage?postDirectory=${uuid}`);
  }



  uploudTest() {
    return this.http.post(this.configService.domain +'Image/UploadTest', {
      responseType: 'text',
    });
  };









}
