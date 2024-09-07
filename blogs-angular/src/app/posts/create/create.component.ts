import { Component,OnInit } from '@angular/core';
// import { initFlowbite } from 'flowbite';

import { Router } from '@angular/router';
import { Labels, Posts } from '../posts';
import { PostsService } from '../posts.service';
import { Categories } from 'src/app/categories/categories';
import { CategoriesService } from 'src/app/categories/categories.service';
import { HttpClient } from '@angular/common/http';
import { EditorChangeContent, EditorChangeSelection } from 'ngx-quill';
import { ImagesService } from 'src/app/images/images.service';


@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {
  allCategories: Categories[] = [];
  allLabels: Labels[] =[]
  allLabels2: Labels[] =[]
  postForm: Posts = {
    postId: 0,
    postDirectory:'',
    title: '',
    categoryTitle: '',
    description: '',
    labels: [],
    active:true,
    categoryId:0,
    userId:''

  };
  public labels: Labels = {
    labelName: '',
  };
   labelsAdd: Labels = {
    labelName: '',
  };
  public labelsArray = new Array();

   
  randomUUID: string = crypto.randomUUID();


  constructor(private postService:PostsService,
    private router:Router,
    private categoryService: CategoriesService,
    private imagesService: ImagesService ) {}
 
    
     
  ngOnInit(): void {
    // initFlowbite();
    this.getCategories();
     
    console.log(this.randomUUID)
    console.log(this.randomUUID)
    console.log(this.randomUUID)
  }

  labelRegister():void{
    var length = this.labelsArray.push(this.labels.labelName) 

    this.labels.labelName = ''
   }
  labelRemove(label:any){
 
    delete this.labelsArray[this.labelsArray.findIndex(item => item == label)]; 
    this.labelsArray = this.labelsArray.filter(item => item); 
  }
  
  create(){
    console.log("create")
 
    for(let item of this.labelsArray){

      this.labels = {
        labelName: item,
      };

     this.postForm.labels?.push( this.labels)
       console.log(this.postForm.labels )

    }
    const authUserId = localStorage.getItem('authUserId');
    if(authUserId){
      this.postForm.userId = authUserId
    }

    console.log("this.postForm" )
    console.log("this.postForm" )
    console.log("this.postForm" )

    this.postForm.postDirectory = this.randomUUID


    console.log(this.postForm )


    this.postService.create(this.postForm)
    .subscribe({
      next:(data) => {
        this.router.navigate(["/posts/home"])
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



  submitDatafile(fileQ: any, range: any) {

    let fromData = new FormData();
    fromData.set("randomUUID", this.randomUUID)
    fromData.set("file", fileQ)

    console.log("submitDatafile submitDatafile submitDatafile")
    console.log(fileQ.name)
    console.log(fileQ)


    

 

    this.imagesService.uploudPost(fromData).subscribe({
      next: (data) => {
        console.log(" response response response response response")
        console.log(data)

        this.imagesService.getByUrl( this.randomUUID,fileQ.name).subscribe((res: any) => {
          if (res?.status) {
            console.log("getByUrl if")
            console.log(res)
            this.quillEditorRef.insertEmbed(range.index, 'image', res?.image_url);
          } else {
            console.log("getByUrl else")
            console.log(res)

            this.quillEditorRef.insertEmbed(range.index, 'image', res);
          }
        }
        )
      },
      error: (err) => {
        console.log(err);
      }
    });
  }



  


  editorText = ""
  changedEditor(event: EditorChangeContent | EditorChangeSelection) {
    console.log('editor get changed', event);
    this.editorText = event['editor']['root']['innerHTML'];
  }


  quillEditorRef: any;
  getEditorInstance(editorInstance: any) {
    this.quillEditorRef = editorInstance;

    console.log('111111111111111111111111111111111');
    console.log(editorInstance);

    const toolbar = this.quillEditorRef.getModule('toolbar');
    // toolbar.addHandler('image', this.imageHandler);
    toolbar.addHandler('image', this.uploadImageHandler);
  }


  uploadImageHandler = () => {
    console.log("Root image handler", this.quillEditorRef);
    const input = document.createElement('input');
    input.setAttribute('type', 'file');
    input.setAttribute('accept', 'image/*');
    input.click();
    input.onchange = async () => {
      const file = input.files?.length ? input.files[0] : null;

      console.log('xxxxxxxxxxxxxxxxxxxxxxx');
      console.log('User trying to uplaod this:', file);
      console.log('ooooooooooooooooooooooooooooooooooooo');

      console.log("this.quillEditorRef", this.quillEditorRef);
      const range = this.quillEditorRef.getSelection();
      // const id = await 

      this.submitDatafile(file, range)
    }
  }
















}
