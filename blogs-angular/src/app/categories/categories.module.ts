import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoriesRoutingModule } from './categories-routing.module';
 import { FormsModule } from '@angular/forms';
import { CategoriesCreateComponent } from './categories-create/categories-create.component';
import { homeCategoriesComponent } from './home-categories/home-categories.component';
 

@NgModule({
  declarations: [
 
      
  ],
  imports: [
    CommonModule,
    CategoriesRoutingModule,
    FormsModule
  ],
  exports:[
     
  ]
})
export class CategoriesModule { }
