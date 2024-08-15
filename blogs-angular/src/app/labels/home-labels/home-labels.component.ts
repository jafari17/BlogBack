import { Component } from '@angular/core';
// import { Labels } from '../labels';
// import { LabelsService } from '../labels.service';

@Component({
  selector: 'app-home-labels',
  templateUrl: './home-labels.component.html',
  styleUrls: ['./home-labels.component.css']
})
export class HomeLabelsComponent {
  // allLabels: Labels[] = [];

  // constructor(private labelService: LabelsService) {}
 
//   ngOnInit(): void {
//     this.getLabels();
//   }
 
//   getLabels() {
//     this.labelService.get().subscribe((data) => {
//       this.allLabels = data;
//     });
//   }

//   deleteItem(id:number) {
//     this.labelService.delete(id).subscribe({
//       next: (data) => {
//         this.allLabels = this.allLabels.filter(x => x.id != id)
//       },
//     });
// }



}
