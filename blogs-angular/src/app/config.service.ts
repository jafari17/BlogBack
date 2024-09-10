import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {

  domain: string = 'http://localhost:8080/';  

 }
