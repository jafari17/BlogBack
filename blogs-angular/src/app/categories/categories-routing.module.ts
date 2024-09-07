import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
 import { CategoriesCreateComponent } from './categories-create/categories-create.component';
import { homeCategoriesComponent } from './home-categories/home-categories.component';

const routes: Routes = [
  // {
  //   path: 'categories/home',
  //   component: homeCategoriesComponent,
  // },
  // {
  //   path: 'categories/create',
  //   component: CategoriesCreateComponent,
  // },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CategoriesRoutingModule { }


