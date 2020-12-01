import { Component, EventEmitter, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-images-fullscreen',
  templateUrl: './images-fullscreen.component.html',
  styleUrls: ['./images-fullscreen.component.css']
})
export class ImagesFullscreenComponent implements OnInit {

  source: string;
  public eventClosed: EventEmitter<any> = new EventEmitter();

  constructor(public bsModalRef: BsModalRef) { }

  ngOnInit() {
    console.log("testing the source passing")
    console.log(this.source)
  }

  onClickClose(){
    this.eventClosed.emit(true);
    this.bsModalRef.hide();
  }
}
