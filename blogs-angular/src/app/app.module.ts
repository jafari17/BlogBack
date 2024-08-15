import { NgModule } from '@angular/core';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PostsModule } from './posts/posts.module';
import { HttpClientModule } from '@angular/common/http';
import { NavComponent } from './nav/nav.component';
import { SideComponent } from './side/side.component';
import { CategoriesModule } from './categories/categories.module';
import { LabelsModule } from './labels/labels.module';
import { PagesModule } from './pages/pages.module';
import { FormsModule } from '@angular/forms';
import { QuillModule } from "ngx-quill";
import { DashboardModule } from './dashboard/dashboard.module';

@NgModule({
  declarations: [
    AppComponent,

     
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    PostsModule,
    HttpClientModule,
    CategoriesModule,
    LabelsModule,
    DashboardModule,
    PagesModule,
    FormsModule,
    QuillModule.forRoot({
      customOptions: [{
        import: 'formats/font',
        whitelist: ['mirza', 'roboto', 'aref', 'serif', 'sansserif', 'monospace']
      }]
   })
   ],
  providers: [],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  bootstrap: [AppComponent]
})
export class AppModule { }

