import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {


 userName = "";
 constructor(
   private route: ActivatedRoute,
  private router:Router,
) {}
ngOnInit(): void {

    const email = localStorage.getItem('authEmail');

    if (email) {
      this.userName =  email
      
      
    }
}
   logout(){
    localStorage.removeItem('authToken')
    localStorage.removeItem('authEmail')
    localStorage.removeItem('authUserId')

    this.router.navigate(["/auth/login"]);
   }


}

