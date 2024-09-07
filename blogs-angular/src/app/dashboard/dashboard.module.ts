import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { LayoutDashboardComponent } from './layout-dashboard/layout-dashboard.component';
import { NavComponent } from '../nav/nav.component';
import { SideComponent } from '../side/side.component';
import { HomeComponent } from '../posts/home/home.component';
import { CreateComponent } from '../posts/create/create.component';
import { EditComponent } from '../posts/edit/edit.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { QuillModule } from "ngx-quill";
import { homeCategoriesComponent } from '../categories/home-categories/home-categories.component';
import { CategoriesCreateComponent } from '../categories/categories-create/categories-create.component';
import { HomeImageComponent } from '../images/home-image/home-image.component';


@NgModule({
  declarations: [
    LayoutDashboardComponent,
    NavComponent,
    SideComponent,
    HomeComponent,
    CreateComponent,
    EditComponent,
    homeCategoriesComponent,
    CategoriesCreateComponent,
    HomeImageComponent,
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    QuillModule.forRoot({
      customOptions: [{
        import: 'formats/font',
        whitelist: ['mirza', 'roboto', 'aref', 'serif', 'sansserif', 'monospace']
      }]
   })
  ]
})
export class DashboardModule { }
