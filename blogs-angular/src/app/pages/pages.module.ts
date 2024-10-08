import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PagesRoutingModule } from './pages-routing.module';
import { HomePagesComponent } from './home-pages/home-pages.component';
import { PostPagesComponent } from './post-pages/post-pages.component';
import { LabelPagesComponent } from './label-pages/label-pages.component';
import { CategoryPagesComponent } from './category-pages/category-pages.component';
import { LayoutPagesComponent } from './layout-pages/layout-pages.component';
import { NavPagesComponent } from './nav-pages/nav-pages.component';
import { FooterPagesComponent } from './footer-pages/footer-pages.component';
import { LoginComponent } from '../users/login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegisterComponent } from '../users/register/register.component';
 

@NgModule({
  declarations: [
    HomePagesComponent,
    PostPagesComponent,
    LabelPagesComponent,
    CategoryPagesComponent,
    LayoutPagesComponent,
    NavPagesComponent,
    FooterPagesComponent,
    LoginComponent,
    RegisterComponent

  ],
  imports: [
    CommonModule,
    PagesRoutingModule,
    FormsModule,
    ReactiveFormsModule,
 
  ]
})
export class PagesModule { }
