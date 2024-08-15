import { Component, OnInit } from '@angular/core';
import { Categories } from '../categories';
import { CategoriesService } from '../categories.service';
 
@Component({
  selector: 'app-home',
  templateUrl: './home-categories.component.html',
  styleUrls: ['./home-categories.component.css']
})
export class homeCategoriesComponent implements OnInit {
  allCategories: Categories[] = [];
 
  constructor(private categoryService: CategoriesService) {}
 
  ngOnInit(): void {
    this.get();
    console.log(this.allCategories)
  }

  public onClick(){
    console.log('test output')
  }
  public userAdded(users: Categories[]) {
    console.log('test output')
    this.get();

  }




  get() {
    this.categoryService.get().subscribe((data) => {
      this.allCategories = data;
    });
  }

  deleteItem(categoryId:number) {
    this.categoryService.delete(categoryId).subscribe({
      next: (data) => {
        console.log(categoryId ),
        this.allCategories = this.allCategories.filter(x => x.categoryId != categoryId)
         
      },
    });
}
}


 
 