import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LabelsRoutingModule } from './labels-routing.module';

import { HomeLabelsComponent } from './home-labels/home-labels.component';


@NgModule({
  declarations: [
       HomeLabelsComponent
  ],
  imports: [
    CommonModule,
    LabelsRoutingModule
  ]
})
export class LabelsModule { }


 