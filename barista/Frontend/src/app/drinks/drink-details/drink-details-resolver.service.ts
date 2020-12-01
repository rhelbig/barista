import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, Router, RouterStateSnapshot } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Drink } from 'src/app/models/drink';
import { DrinkService } from 'src/app/services/drink.service';

@Injectable({
  providedIn: 'root'
})
export class DrinkDetailsResolverService implements Resolve<Drink> {

constructor(private router: Router, private drinkService: DrinkService) { }

resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot):
Observable<Drink>|Drink {
  const drinkId = route.params['id'];
  return this.drinkService.getDrink(drinkId).pipe(
    catchError(error => {
      console.log(error);
      this.router.navigate(['/page-not-found']);
      return of(null);
    })
  );
}

}
