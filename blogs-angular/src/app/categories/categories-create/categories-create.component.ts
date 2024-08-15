import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { Categories } from '../categories';
import { CategoriesService } from '../categories.service';

@Component({
  selector: 'app-categories-create',
  templateUrl: './categories-create.component.html',
  styleUrls: ['./categories-create.component.css']
})
export class CategoriesCreateComponent implements OnInit {


  @Output() onAddUserClicked = new EventEmitter();


  public categoryForm: Categories = {
    categoryId: 0,
    titleCategory: '',
    descriptionCategory: ''
  };
 
  constructor(private categoryService:CategoriesService,
    private router:Router) {}
 
  ngOnInit(): void {}
 
  create(){
    this.categoryService.create(this.categoryForm)
    .subscribe({
      next:(data) => {
        this.router.navigate(["/categories/home"])
      },
      error:(err) => {
        console.log(err);
      }
    })
    this.onAddUserClicked.emit();
  }
}

