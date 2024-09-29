import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { UserLogin } from './userLogin';
import { UserRegister } from './userRegister';
import { ConfigService } from '../config.service';
 

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private http: HttpClient, private configService: ConfigService) {}

  public register(user: UserRegister): Observable<any> {
    return this.http.post<any>(
      this.configService.domain +'register',user);
  }

  public login(userLogin: UserLogin): Observable<any> {
    return this.http.post<any>(this.configService.domain +'login', userLogin );
  }

  public getMe(): Observable<string> {
    return this.http.get(this.configService.domain +'api/Auth', {
      responseType: 'text',
    });
  }

  public getWeather(): Observable<string> {
    return this.http.get(this.configService.domain +'WeatherForecast', {
      responseType: 'text',
    });
  }
  public getUserIdByEmail(userEmail: string)  {
    return this.http.get(this.configService.domain +`api/UserManager/GetUserIdByEmail?userEmail=${userEmail}`,{
      responseType: 'text',
    });    
  }

  public getEmailByUserId(idUser: string)  {
    return this.http.get(this.configService.domain +`api/UserManager/GetUserEmailById?idUser=${idUser}`,{
      responseType: 'text',
    });    
  }

  public checkingLogin(): Observable<string> {
    return this.http.get(this.configService.domain +'api/UserManager/CheckingLogin', {
      responseType: 'text',
    });
  }
}