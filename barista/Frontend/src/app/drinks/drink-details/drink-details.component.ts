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
        srcUrl: 'assets/drinks/beer-default.gif',
        previewUrl: 'assets/drinks/beer-default.gif'
      },
      {
        srcUrl: 'assets/drinks/wine-default.png',
        previewUrl: 'assets/drinks/wine-default.png'
      },
      {
        srcUrl: 'assets/drinks/coffee-default.png',
        previewUrl: 'assets/drinks/coffee-default.png'
      }
    ]
  }
}
