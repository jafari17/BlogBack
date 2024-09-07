import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ImagesService } from '../images.service';

@Component({
  selector: 'app-home-image',
  templateUrl: './home-image.component.html',
  styleUrls: ['./home-image.component.css']
})
export class HomeImageComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private imagesService: ImagesService
  ) { }

  allImage: string[] = [];
  ngOnInit(): void {

    this.route.paramMap.subscribe((param) => {
      var uuid = String(param.get('uuid'));

      console.log(uuid)

      this.getListImage(uuid);

    });


    }


    getListImage(uuid: string) {
      this.imagesService.getListImage(uuid).subscribe((data) => {
        console.log(data)
        this.allImage = data;
      });

  }




}
