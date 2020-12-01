import { Injectable } from '@angular/core';
import * as alertify from 'alertifyjs'

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

constructor() { }

success(message: String){
  alertify.success(message);
}
error(message: String){
  alertify.error(message);
}
warning(message:string) {
  alertify.warn(message);

}
}
