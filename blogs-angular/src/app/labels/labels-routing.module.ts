import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeLabelsComponent } from './home-labels/home-labels.component';
 
const routes: Routes = [
  {
    path: 'labels/home',
    component: HomeLabelsComponent,
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LabelsRoutingModule { }


