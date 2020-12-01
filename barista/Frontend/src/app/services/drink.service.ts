import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Drink } from '../models/drink';

const DRINK_API = "http://localhost:5000/api/drink/";

const httpOptions = {
  headers: new HttpHeaders({'content-type': 'application/json'})
};

@Injectable({
  providedIn: 'root'
})
export class DrinkService {

  constructor(private http: HttpClient) { }

  getDrink(id: number): Observable<any> {
    return this.http.get(DRINK_API + id, httpOptions);
  }

  addDrink(drink): Observable<any> {
    return this.http.put(DRINK_API + 'add', drink, httpOptions);
  }

  getAllDrinks(drinkType?: number): Observable<Drink[]>{
    return this.http.get(DRINK_API, httpOptions).pipe(
      map(data => {
        const drinksArray: Array<Drink> = [];
        for(const Id in data) {
          if(drinkType){
            if(data.hasOwnProperty(Id) && data[Id].drinkType === drinkType){
              drinksArray.push(data[Id]);
            }
          } else {
            drinksArray.push(data[Id]);
          }

        }
        return drinksArray;
      })
    );
  }

}
