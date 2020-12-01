import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
import { Routes, RouterModule} from '@angular/router'
import { FormsModule, ReactiveFormsModule } from '@angular/forms'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { ButtonsModule } from 'ngx-bootstrap/buttons';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { PopoverModule } from 'ngx-bootstrap/popover';
import { ModalModule } from "ngx-bootstrap/modal";

import { AppComponent } from './app.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { UserRegisterComponent } from './user/user-register/user-register.component';
import { UserLoginComponent } from './user/user-login/user-login.component';
import { AuthService } from './services/auth.service';
import { FilterPipe } from './Pipes/filter.pipe';
import { SortingPipe } from './Pipes/sorting.pipe';
import { DrinkListComponent } from './drinks/drink-list/drinks-list.component';
import { DrinkCardComponent } from './drinks/drink-card/drink-card.component';
import { DrinkDetailsComponent} from './drinks/drink-details/drink-details.component';
import { DrinkDetailsResolverService } from './drinks/drink-details/drink-details-resolver.service';
import { AddDrinkComponent } from './drinks/add-drink/add-drink.component';
import { UploadImageComponent } from './upload-image/upload-image.component';

const appRoutes: Routes = [
  {path: '', component: DrinkListComponent},
  {path: 'beer', component: DrinkListComponent},
  {path: 'wine', component: DrinkListComponent},
  {path: 'coffee', component: DrinkListComponent},
  {path: 'add-drink', component: AddDrinkComponent},
  {path: 'drink-detail/:id', component: DrinkDetailsComponent, resolve: {drs: DrinkDetailsResolverService}},
  {path: 'user/login', component: UserLoginComponent},
  {path: 'user/register', component: UserRegisterComponent},
  {path: '**', component: PageNotFoundComponent}
]
@NgModule({
  declarations: [	
    AppComponent,
    DrinkListComponent,
    DrinkCardComponent,
    DrinkDetailsComponent,
    AddDrinkComponent,
    NavBarComponent,
    PageNotFoundComponent,
    UserLoginComponent,
    UserRegisterComponent,
    FilterPipe,
    SortingPipe,
      UploadImageComponent
   ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forRoot(appRoutes),
    FormsModule,
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(),
    TabsModule.forRoot(),
    ButtonsModule.forRoot(),
    BsDatepickerModule.forRoot(),
    CarouselModule.forRoot(),
    PopoverModule.forRoot(),
    ModalModule.forRoot(),
  ],
  providers: [
    AuthService,
    DrinkDetailsResolverService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
