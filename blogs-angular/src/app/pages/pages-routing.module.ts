import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePagesComponent } from './home-pages/home-pages.component';
import { PostPagesComponent } from './post-pages/post-pages.component';
import { homeCategoriesComponent } from '../categories/home-categories/home-categories.component';
import { CategoryPagesComponent } from './category-pages/category-pages.component';
import { LabelPagesComponent } from './label-pages/label-pages.component';
import { LayoutPagesComponent } from './layout-pages/layout-pages.component';

const routes: Routes = [
  {
    path:'',
    component: LayoutPagesComponent,
    children:[
      {
        path:'pages/home',
        component: HomePagesComponent
      },
      {
        path:'pages/post/:id',
        component: PostPagesComponent
      },
      {
        path:'pages/category/:category',
        component: CategoryPagesComponent
      },
      {
        path:'pages/label/:label',
        component: LabelPagesComponent
      }
    ]
  },
 
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PagesRoutingModule { }
