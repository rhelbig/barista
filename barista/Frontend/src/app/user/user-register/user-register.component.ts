import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { User } from 'src/app/models/user';
import { AlertifyService } from 'src/app/services/alertify.service';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.css']
})
export class UserRegisterComponent implements OnInit {

  user: User;
  userSubmitted: boolean;
  isSuccessful = false;
  isSignUpFailed = false;
  errorMessage = '';
  registrationForm: FormGroup;
  constructor(private autService: AuthService,
    private fb: FormBuilder,
    private alertifyService: AlertifyService) { }

  ngOnInit() {

    this.createRegistrationForm();
  }

  createRegistrationForm(){
    this.registrationForm = this.fb.group({
      userName: [null, Validators.required],
      userEmail: [null, [Validators.required, Validators.email]],
      userPassword: [null, [Validators.required, Validators.minLength(8)]],
      userPasswordConf: [null, [Validators.required, Validators.minLength(8)]],
      userFirstName: [null, Validators.required],
      userLastName: [null, Validators.required],
      userMobile: [null, [Validators.minLength(10)]]
    }, {Validators: [this.passwordMatchingValidator]})
  }

  passwordMatchingValidator(fg: FormGroup): Validators {
    return fg.get('userPassword').value === fg.get('userPasswordConf').value ? null : {notmatched: true}
  }

  get UserInfoInfo() {
    return this.registrationForm.controls.registrationForm as FormGroup;
  }
  get userName(){
    return this.registrationForm.controls.userName as FormControl;
  }
  get userEmail(){
    return this.registrationForm.controls.userEmail as FormControl;
  }
  get userPassword(){
    return this.registrationForm.controls.userPassword as FormControl;
  }
  get userPasswordConf(){
    return this.registrationForm.controls.userPasswordConf as FormControl;
  }
  get userFirstName(){
    return this.registrationForm.controls.userFirstName as FormControl;
  }
  get userLastName(){
    return this.registrationForm.controls.userLastName as FormControl;
  }
  get userMobile(){
    return this.registrationForm.controls.userMobile as FormControl;
  }

  onSubmit(){
    this.userSubmitted = true;
    if(this.registrationForm.valid){
      this.autService.register(this.userData()).subscribe(
        data => {
          this.isSuccessful = true;
          this.isSignUpFailed = false;
          this.alertifyService.success('You have successfully added a user!');
        },
        err => {
          this.errorMessage = err.error;
          this.isSignUpFailed = true;
        }
      );

      //potentially find a way to
      //this.autService.registerUser(this.userData());

      //this.userService.addUser(this.userData());
      //this.registrationForm.reset();
      //this.userSubmitted = false;
      //this.alertifyService.success('You have successfully added a user!');
    } else {
      this.alertifyService.error('Something went wrong');

    }
  }

  userData(): User {
    return this.user = {
      userName: this.userName.value,
      userEmail: this.userEmail.value,
      userPassword: this.userPassword.value,
      userFirstName: this.userFirstName.value,
      userLastName: this.userLastName.value,
      userMobile: +this.userMobile.value,
      userToken: null
    }
  }
}
