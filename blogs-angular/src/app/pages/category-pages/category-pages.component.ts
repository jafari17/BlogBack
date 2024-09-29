import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Labels, Posts } from 'src/app/posts/posts';
import { PostsService } from 'src/app/posts/posts.service';

@Component({
  selector: 'app-category-pages',
  templateUrl: './category-pages.component.html',
  styleUrls: ['./category-pages.component.css']
})
export class CategoryPagesComponent implements OnInit  {
  allPosts: Posts[] = [];
  allPostsSave: Posts[] = [];

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

  constructor(
    private route: ActivatedRoute,
    private router:Router,
    private postService: PostsService,
   ) {}
 
   ngOnInit(): void {

    this.route.paramMap.subscribe((param) => {
      var category = String(param.get('category'));
      console.log(category)

      // this.getByCategory(category);
      this.getPostsShowCategory(category);

    })

     console.log(this.allPosts)
  }
   


  getByCategory(category: string) {
    this.postService.getByCategory(category).subscribe((data) => {
      this.allPosts = data;
      console.log(this.allPosts)
     });
  }

  getPostsShowCategory(category: string) {
    console.log("getPosts()")
    this.postService.get().subscribe((data) => {
      
      this.allPosts = data;

      this.allPosts = this.allPosts.filter(x => x.categoryTitle == category) 
     });
  }
}
