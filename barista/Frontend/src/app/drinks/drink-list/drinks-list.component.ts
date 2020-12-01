import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Drink } from 'src/app/models/drink';
import { DrinkService } from 'src/app/services/drink.service';

const BEER_URL = 'beer';
const WINE_URL = 'wine';
const COFFEE_URL = 'coffee';


@Component({
  selector: 'app-drinks-list',
  templateUrl: './drink-list.component.html',
  styleUrls: ['./drink-list.component.css']
})
export class DrinkListComponent implements OnInit {
  drinkType = null;
  filterBy = '';
  filterByParam = '';
  filterValue = '';
  filterValueParam = '';

  sortBy = '';
  sortByParam = '';
  descending = false;

  drinks: Array<Drink>;

  constructor(private route: ActivatedRoute, private drinkServices: DrinkService) { }

  ngOnInit() {
    var navigateType = this.route.snapshot.url.toString();
    if(navigateType === BEER_URL){
      this.drinkType = 1;
    } else if(navigateType === WINE_URL){
      this.drinkType = 2;
    } else if(navigateType === COFFEE_URL){
      this.drinkType = 3;
    } else {
      this.drinkType = null;
    }

    this.drinkServices.getAllDrinks(this.drinkType).subscribe(
      data=>{
        this.drinks=data;
      },error =>{
        console.log(error);
      }
    );
  }

  onFilter(){
    this.filterByParam = this.filterBy;
    if(this.filterByParam === 'Price'){
      this.filterValue = this.filterValue.toString();
    } else {
      this.filterValueParam = this.filterValue;
    }

  }
  onFilterReset(){
    this.filterByParam = '';
    this.filterBy = '';
    this.filterValue = '';
    this.filterValueParam = '';
  }
  onDescendingChanged(e){
    this.descending = e.target.checked;
  }

}
