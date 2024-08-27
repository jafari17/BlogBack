import { AfterContentChecked, AfterViewInit, Component, OnInit } from '@angular/core';
import { UserRegister } from '../userRegister';
import { AuthService } from '../auth.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit  {

  user = new UserRegister();
  errList: String[] = [];

  constructor(
    private authService: AuthService,
    private route: ActivatedRoute,
    private router:Router,
  ) {}
  
  ngOnInit(): void { 
    this.checkingLogin() 
    }
 
  register(user: UserRegister) {
    this.authService.register(user)
    .subscribe({
      next:(data: string) => {

        this.router.navigate(["/auth/login"]);
      },
      error:(err) => {
        this.errList  = [];
        for(let i in err["error"]["errors"]  ){
          console.log(i);
          this.errList.push(i)
         } 
      }
    });  
  }
  
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
