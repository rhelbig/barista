import { Component, Input, OnInit } from '@angular/core';
import { Drink } from 'src/app/models/drink';

@Component({
  selector: 'app-drink-card',
  templateUrl: './drink-card.component.html',
  styleUrls: ['./drink-card.component.css']
})

export class DrinkCardComponent implements OnInit{
  ngOnInit(): void {
    this.createImgPath("");
  }
  @Input() drink: Drink;
  @Input() hideIcons: boolean;

  public createImgPath = (serverPath: string) => {
    return `http://localhost:5000/${serverPath}`;
  }
}

