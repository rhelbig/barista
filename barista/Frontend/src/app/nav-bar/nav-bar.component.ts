import { Component, OnInit } from '@angular/core';
import { AlertifyService} from 'src/app/services/alertify.service'
import { TokenStorageService } from '../services/token-storage.service';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent implements OnInit {
  loggedInUser: String;

  constructor(private alertifyService: AlertifyService,
    private tokenStorage: TokenStorageService) { }

  ngOnInit() {
  }

  loggedIn(){
    if(this.tokenStorage.getUser()){
      this.loggedInUser = this.tokenStorage.getUser()['firstName'];
    }
    return this.loggedInUser;
  }
  onLogout(){
    this.tokenStorage.signOut();
    this.loggedInUser = '';
    this.alertifyService.success('You have successfully logged out!')
  }

}
