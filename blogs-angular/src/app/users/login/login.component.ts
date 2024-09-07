import { AfterViewInit, Component, OnInit } from '@angular/core';
import { UserRegister } from '../userRegister';
import { AuthService } from '../auth.service';
import { UserLogin } from '../userLogin';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit   {
  title = 'NgDotNetAuth.UI';
  user = new UserRegister();
  errtitel=''
   constructor(
    private authService: AuthService,
    private route: ActivatedRoute,
    private router:Router,
  ) {}

  ngOnInit(): void {

    this.checkingLogin()
      
    }
  login(user: UserRegister) {

    var userLogin = new UserLogin();

    userLogin.email = user.email;
    userLogin.password = user.password;
    userLogin.twoFactorCode = '';
    userLogin.twoFactorRecoveryCode = '';

    console.log(userLogin);

    this.authService.login(userLogin) 

      .subscribe({
        next:(token: any) => {
  
          localStorage.setItem('authToken', token['accessToken']);

          localStorage.setItem('authEmail', userLogin.email);
     
          console.log("authService.login");
          console.log(token['accessToken']);
          console.log("getEmailLocalStorage")
    
  
        this.getUserIdByEmail(userLogin.email);
        },
        error:(err) => {
          console.log("ddddddddddddd");
          this.errtitel = "نام کاربری یا رمز عبور اشتباه است"
          console.log(err);
        }

    });
 
  }

  getUserIdByEmail(userEmail: string) {

    console.log("getUserIdByEmail")

    this.authService.getUserIdByEmail(userEmail) 
      
    .subscribe({
      next:(data) => {

        console.log(data);
        localStorage.setItem('authUserId', data);

        this.router.navigate(["/posts/home"]);
      },
      error:(err) => {
        console.log(err);
      }
    });
    
     };

  
  checkingLogin(){
    this.authService.checkingLogin()
     
    .subscribe({
      next:(data: string) => {

         if( data === "true")
         {
          this.router.navigate(["/posts/home"]);
         }
      },
      error:(err) => {
        console.log(err);
      }
    });
  }

 
}
