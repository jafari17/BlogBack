import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PostsRoutingModule } from './posts-routing.module';
import { HomeComponent } from './home/home.component';
import { CreateComponent } from './create/create.component';
import { FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EditComponent } from './edit/edit.component';
import { QuillModule } from "ngx-quill";
@NgModule({
  declarations: [
 
     
     
  ],
  imports: [
    CommonModule,
    PostsRoutingModule,

     
  ],
  exports:[
   ]
})
export class PostsModule { }
