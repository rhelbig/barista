import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

const AUTH_API = "http://localhost:5000/api/auth/";

const httpOptions = {
  headers: new HttpHeaders({'content-type': 'application/json'})
};
@Injectable({
  providedIn: 'root'
})
export class AuthService {

constructor(private http:HttpClient) { }

login(credentials): Observable<any> {
  return this.http.post(AUTH_API + 'login', credentials, httpOptions);
}

register(user): Observable<any> {
  return this.http.put(AUTH_API + 'register', user)
}








authUser(user: any) {
  //let UserArray = [];
  //if(localStorage.getItem('Users')){
  //  UserArray = JSON.parse(localStorage.getItem('Users'));
  //}
  //return UserArray.find(p => p.userName === user.userName && p.userPassword === user.userPassword);

  this.http.post('http://localhost:5000/api/auth/login', user).subscribe(response => {
    console.log((<any>response).token);
    localStorage.setItem('token', (<any>response).token);
    return true;
  }, err => {
    console.log("User login issue:");
    console.log(err);
    return false;
  });
  console.log("here");
  //return this.http.post('localhost:5000/api/auth/login', user);
}

registerUser(user: any){
  console.log("the response is.....");
  this.http.put('http://localhost:5000/api/auth/register', user).subscribe(response => {

    console.log(response);

  });
  console.log("end of response");
}
}
