import { Component, OnInit } from '@angular/core';
import { Categories } from 'src/app/categories/categories';
import { CategoriesService } from 'src/app/categories/categories.service';

@Component({
  selector: 'app-footer-pages',
  templateUrl: './footer-pages.component.html',
  styleUrls: ['./footer-pages.component.css']
})
export class FooterPagesComponent implements OnInit{
  allCategories: Categories[] = [];

  constructor(private categoryService: CategoriesService) {}

  ngOnInit(): void {
    // initFlowbite();
    this.getCategories();

 
  }

  getCategories() {
    this.categoryService.get().subscribe((data) => {
      this.allCategories = data;
    });
  }

}
