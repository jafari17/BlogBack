import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Labels, Posts } from 'src/app/posts/posts';
import { PostsService } from 'src/app/posts/posts.service';
 
@Component({
  selector: 'app-home-pages',
  templateUrl: './home-pages.component.html',
  styleUrls: ['./home-pages.component.css']
})
export class HomePagesComponent implements OnInit  {
  allPosts: Posts[] = [];
  allPostsSave: Posts[] = [];

 

  constructor(
    private route: ActivatedRoute,
    private router:Router,
    private postService: PostsService,
   ) {}
 
   ngOnInit(): void {
    this.getPosts();
    console.log(this.allPosts)
  }
   
  getPosts() {
    console.log("getPosts()")
    this.postService.get().subscribe((data) => {
      
      this.allPosts = data;
      this.allPostsSave = data;

     });
  }

}


