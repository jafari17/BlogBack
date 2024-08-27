import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Labels, Posts } from '../posts';
import { PostsService } from '../posts.service';
// import { initFlowbite } from 'flowbite';
import { Categories } from 'src/app/categories/categories';
import { CategoriesService } from 'src/app/categories/categories.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
 public postForm: Posts = {
    postId: 0,
    title: '',
    categoryTitle: '',
    description: '',
    labels: [],
    categoryId:0,
    userId:''

  };
  labels: Labels = {
    labelName: '',
  };
  allCategories: Categories[] = [];
  public labelsArray = new Array();

  constructor(
    private route: ActivatedRoute,
    private router:Router,
    private postService: PostsService,
    private categoryService: CategoriesService
  ) {}
 
  ngOnInit(): void {
    this.getCategories();

    this.route.paramMap.subscribe((param) => {
      var id = Number(param.get('id'));

      
      this.getById(id);
    });

    // initFlowbite();
    


  }

  labelRegister():void{
    var length = this.labelsArray.push(this.labels.labelName) 

    this.labels.labelName = ''
   }
  labelRemove(label:any){
 
    delete this.labelsArray[this.labelsArray.findIndex(item => item == label)]; 
    this.labelsArray = this.labelsArray.filter(item => item); 
  }
  getById(id: number) {
    this.postService.getById(id).subscribe((data) => {
      this.postForm = data;

      console.log(this.postForm )

      for(let item of this.postForm.labels?? [])
      {
        this.labelsArray.push(item.labelName)
        
      }
      console.log(this.labelsArray)

     });
  }
 
  update() {
    console.log("update")

    this.postForm.labels = []
    for(let item of this.labelsArray){

      this.labels = {
        labelName: item,
      };

     this.postForm.labels?.push( this.labels)
       console.log(this.postForm.labels )

    }



    this.postService.update(this.postForm)
    .subscribe({
      next:(data) => {
        this.router.navigate(["/posts/home"]);
      },
      error:(err) => {
        console.log(err);
      }
    })
  }

  getCategories() {
    this.categoryService.get().subscribe((data) => {
      this.allCategories = data;
    });
  }
}

 