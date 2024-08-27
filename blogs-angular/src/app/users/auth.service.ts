import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { UserLogin } from './userLogin';
import { UserRegister } from './userRegister';
 

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private http: HttpClient) {}

  public register(user: UserRegister): Observable<any> {
    return this.http.post<any>(
      'https://localhost:8081/register',user);
  }

  public login(userLogin: UserLogin): Observable<any> {
    return this.http.post<any>('https://localhost:8081/login', userLogin );
  }

  public getMe(): Observable<string> {
    return this.http.get('https://localhost:8081/api/Auth', {
      responseType: 'text',
    });
  }

  public getWeather(): Observable<string> {
    return this.http.get('https://localhost:8081/WeatherForecast', {
      responseType: 'text',
    });
  }
  public getUserIdByEmail(userEmail: string)  {
    return this.http.get(`https://localhost:8081/api/UserManager/GetUserIdByEmail?userEmail=${userEmail}`,{
      responseType: 'text',
    });    
  }

  public checkingLogin(): Observable<string> {
    return this.http.get('https://localhost:8081/api/UserManager/CheckingLogin', {
      responseType: 'text',
    });
  }
}