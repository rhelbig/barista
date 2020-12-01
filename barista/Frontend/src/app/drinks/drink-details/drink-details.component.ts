import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Drink } from 'src/app/models/drink';
import { ImagesFullscreenComponent } from 'src/app/models/images/images-fullscreen/images-fullscreen.component';
import { DrinkService } from 'src/app/services/drink.service';

@Component({
  selector: 'app-drink-details',
  templateUrl: './drink-details.component.html',
  styleUrls: ['./drink-details.component.css']
})
export class DrinkDetailsComponent implements OnInit {
  public drinkId: string;
  drink = new Drink();

  images = [];
  imageData = this.getImageInfo();

  bsModalRef: BsModalRef;

  constructor(private route: ActivatedRoute,
    private router: Router,
    private drinkService: DrinkService,
    private modalService: BsModalService) { }

  ngOnInit() {
    this.drinkId = (this.route.snapshot.params['id']);
    this.route.data.subscribe(
      (data: Drink) => {
        this.drink = data['drs'];
      }
    )
    this.initiateGallery();
  }

  openImageFullscreen(src: string){
    const initialState = {
      source: src
    };
    this.bsModalRef = this.modalService.show(ImagesFullscreenComponent, {initialState});
    this.bsModalRef.setClass("full-screen-modal");
    this.bsModalRef.content.eventClosed.subscribe((success: boolean) => {
      if (success) {
        // alert("Overlay Closed!");
      }
    });
  }

  onSelectNext() {
    this.drinkId += 1;
    this.router.navigate(['property-detail', this.drinkId]);
  }




  initiateGallery(){

  }

  getImageInfo() {
    return [
      {
        srcUrl: 'http://localhost:5000/Resources/DefaultImages/beer-default.gif',
        previewUrl: 'http://localhost:5000/Resources/DefaultImages/beer-default.gif'
      },
      {
        srcUrl: 'http://localhost:5000/Resources/DefaultImages/wine-default.png',
        previewUrl: 'http://localhost:5000/Resources/DefaultImages/wine-default.png'
      },
      {
        srcUrl: 'http://localhost:5000/Resources/DefaultImages/coffee-default.png',
        previewUrl: 'http://localhost:5000/Resources/DefaultImages/coffee-default.png'
      }
    ]
  }
}
