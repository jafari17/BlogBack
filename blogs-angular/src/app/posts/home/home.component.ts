import { Component, OnInit } from '@angular/core';
import { Posts } from '../posts';
import { PostsService } from '../posts.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  allPosts: Posts[] = [];
  allPostsSave: Posts[] = [];
  constructor(private postService: PostsService) { }

  ngOnInit(): void {
    const authUserId = localStorage.getItem('authUserId');
    if (authUserId) { this.getPostsbyUser(authUserId); }

 
    console.log(this.allPosts)
  }

  getPostsbyUser(id: string) {
    console.log("getPosts()")
    this.postService.getListPostByUserId(id).subscribe((data) => {


      for (var item of data) {

        console.log(item);
        const pTag = item.description.replace(/<img[^>]*>/g, '')
        if (pTag) {

          console.log("pTag pTag pTag pTag pTag pTag ");  
       
          console.log(pTag);
          item.description = pTag;

          this.allPosts.push(item)
          this.allPostsSave.push(item)
        }
      }

       

      console.log("push(item) push(item) push(item) push(item) push(item) push(item) ");  
       
      console.log(this.allPosts);
    });
  }



  deleteItem(id: number) {
    console.log("deleteItem(id:number)")

    console.log(id)

    this.postService.delete(id).subscribe({
      next: (data) => {
        this.allPosts = this.allPosts.filter(x => x.postId != id)
      },
    });
  }


  activeItem(post: Posts) {
    console.log(post.active)
    post.active = !post.active
    console.log(post.active)

    this.postService.update(post).subscribe({
      next: (data) => {
        // this.allPosts = this.allPosts.filter(x => x.id != post) 
      },
    });


  }

  showAll() {
    this.allPosts = this.allPostsSave;

  }


  showActive() {
    this.allPosts = this.allPostsSave;
    this.allPosts = this.allPosts.filter(x => x.active == true)
  }


  showNOActive() {
    this.allPosts = this.allPostsSave;
    this.allPosts = this.allPosts.filter(x => x.active == false)
  }



}