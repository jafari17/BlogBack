import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router  } from '@angular/router';
import { EMPTY } from 'rxjs';
import { Posts } from 'src/app/posts/posts';
import { PostsService } from 'src/app/posts/posts.service';
import { AuthService } from 'src/app/users/auth.service';
import * as moment from 'jalali-moment';

@Component({
  selector: 'app-post-pages',
  templateUrl: './post-pages.component.html',
  styleUrls: ['./post-pages.component.css']
})


export class PostPagesComponent implements OnInit   {
  public postForm: Posts = {
    postId: 0,
    postDirectory:'',
    title: '',
    categoryTitle: '',
    description: '',
    labels: [],
    categoryId:0,
    userId:'',
    postDate:new Date('0000-00-00T00:00:00')
 
  };
  userName = "";
  dateJalali= ""

  constructor(
    private route: ActivatedRoute,
    private router:Router,
    private postService: PostsService,
    private authService: AuthService,
 
   ) {}
 
  ngOnInit(): void {
    this.route.paramMap.subscribe((param) => {
      var id = Number(param.get('id'));
      this.getById(id);

      console.log(this.postForm.userId)

      console.log(this.postForm.postDate)




    });

  

  }
   
  getById(id: number) {
    this.postService.getById(id).subscribe((data) => {
      this.postForm = data;

      this.getEmailByUserId(this.postForm.userId)

      this.dateJalali = moment(this.postForm.postDate, 'YYYY/MM/DD').locale('fa').format('YYYY/M/D');
      
      console.log(this.dateJalali)

     });
  }
  
  getEmailByUserId(userId: string) {
    this.authService.getEmailByUserId(userId).subscribe((data) => {
      this.userName = data;
      console.log(this.userName)


     });
  }
}
