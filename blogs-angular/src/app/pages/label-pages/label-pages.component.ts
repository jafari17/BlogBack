import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Labels, Posts } from 'src/app/posts/posts';
import { PostsService } from 'src/app/posts/posts.service';

@Component({
  selector: 'app-label-pages',
  templateUrl: './label-pages.component.html',
  styleUrls: ['./label-pages.component.css']
})
export class LabelPagesComponent implements OnInit  {
  allPosts: Posts[] = [];
  allPostsSave: Posts[] = [];

  public postForm: Posts = {
    postId: 0,
    title: '',
    categoryTitle: '',
    description: '',
    labels: [],
    categoryId:0,

  };

  constructor(
    private route: ActivatedRoute,
    private router:Router,
    private postService: PostsService,
   ) {}
 
   ngOnInit(): void {

    this.route.paramMap.subscribe((param) => {
      var label = String(param.get('label'));
      console.log(label)

       this.getPostsShowLabel(label);
    })
     console.log(this.allPosts)
  }
   

 

  getPostsShowLabel(label: string) {
    console.log("getPosts()")
    this.postService.get().subscribe((data) => {
      
      this.allPosts = data;
      console.log(this.allPosts)

      this.allPosts = this.allPosts.filter(x => x.labels?.find(c => c.labelName == label )) 

      console.log(this.allPosts)
     });
  }
}


