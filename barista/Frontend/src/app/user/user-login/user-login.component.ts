import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/services/auth.service';
import { AlertifyService} from 'src/app/services/alertify.service'
import { Router } from '@angular/router';
import { TokenStorageService } from 'src/app/services/token-storage.service';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: ['./user-login.component.css']
})
export class UserLoginComponent implements OnInit {
  loginForm: FormGroup;
  isLoggedIn = false;
  isLoginFailed = false;
  errorMessage = '';
  roles: string[] = [];

  constructor(private autService: AuthService,
    private tokenStorage: TokenStorageService,
    private alertifyService: AlertifyService,
    private router: Router) { }

  ngOnInit() {
    if (this.tokenStorage.getToken()) {
      this.isLoggedIn = true;
      this.roles = this.tokenStorage.getUser().roles;
    } else {
      //potentially move createLoginForm here
    }
    this.createLoginForm();
  }

  createLoginForm(){
    this.loginForm = new FormGroup({
      userName: new FormControl(null, Validators.required),
      userPassword: new FormControl(null, [Validators.required, Validators.minLength(8)])
    })
  }

  get userName(){
    return this.loginForm.get('userName') as FormControl;
  }
  get userPassword(){
    return this.loginForm.get('userPassword') as FormControl;
  }
  onLogin(){
    this.autService.login(this.loginForm.value).subscribe(
      data => {
        if(data){
          this.tokenStorage.saveToken(data.token);
          this.tokenStorage.saveUser(data);
          this.isLoginFailed = false;
          this.isLoginFailed = true;
          this.alertifyService.success("You have successfully logged in!");
          this.router.navigate(['/']);
        } else {
          this.isLoginFailed = true;
          this.isLoggedIn = false;
        }
      }, err => {
        this.errorMessage = err.error.errorMessage;
        this.isLoginFailed = true;
        this.isLoggedIn = false;
      }
    )
    //this.autService.authUser(this.loginForm.value);
  }

}
