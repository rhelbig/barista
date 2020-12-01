import { Component, OnInit, SystemJsNgModuleLoader, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, PatternValidator, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { TabsetComponent } from 'ngx-bootstrap/tabs';
import { AuthInterceptor } from 'src/app/helpers/auth.interceptor';
import { Drink } from 'src/app/models/drink';
import { IDrink } from 'src/app/models/idrink';
import { AlertifyService } from 'src/app/services/alertify.service';
import { DrinkService } from 'src/app/services/drink.service';

@Component({
  selector: 'app-add-drink',
  templateUrl: './add-drink.component.html',
  styleUrls: ['./add-drink.component.css']
})

export class AddDrinkComponent implements OnInit {
  @ViewChild('formTabs') formTabs: TabsetComponent;

  addDrinkForm: FormGroup;
  nextClicked: boolean;
  idrink = new IDrink();
  drinkType: Array<{type: number, name: string}> = [
    {type: 1, name: 'Beer'},
    {type: 2, name: 'Wine'},
    {type: 3, name: 'Coffee'}];

  drinkView: IDrink = {
    drinkType: null,
    name: null,
    style: null,
    sizeInMl: null,
    alcContent: null,
    price: null,
    company: null,
    companyLocation: null,
    description: "",
    image: ""
  };

  public imageUploadResponse: {dbPath: ''};
  tmpImagePath = '';


  constructor(private fb: FormBuilder,
    private router: Router,
    private alertify: AlertifyService,
    private drinkService: DrinkService) { }

  ngOnInit() {
    this.createAddDrinkForm();
  }

  createAddDrinkForm(){
    this.addDrinkForm = this.fb.group({
      Overview: this.fb.group({
        DrinkType: [null, Validators.required],
        Name: [null, Validators.required],
        Style: [null, Validators.required],
        Price: [null, Validators.required],
        Size: [null, Validators.required],
        Alcohol: [null, Validators.required],
        Company: [null, Validators.required],
        CompanyLocation: [null, Validators.required]
      }),
      About: this.fb.group({
        Description: [null],
      })

    })
  }

  onBack(){
    this.router.navigate(['/'])
  }
  onSubmit(){
    this.nextClicked = true;
    if(this.alltabsValid()){
      this.mapDrink();
      this.drinkService.addDrink(this.idrink).subscribe(data => {
        this.alertify.success("You have successfully added a new drink!");
        if(this.DrinkType.value === 1){
          this.router.navigate(['/beer']);
        } else if(this.DrinkType.value === 2){
          this.router.navigate(['/wine']);
        } else if(this.DrinkType.value === 3){
          this.router.navigate(['/coffee']);
        }
      },
      err => {
        console.log(err)
      }
    );

    } else {
      this.alertify.error("Something still needs to be filled out")
    }
  }

  alltabsValid() : boolean {
    if(this.Overview.invalid){
      this.formTabs.tabs[0].active = true;
      return false;
    } else if(this.About.invalid){
      this.formTabs.tabs[1].active = true;
      return false;
    } else {
      return true;
    }

  }


  //-----------------------
  //getters
  //----------------------
  //overview tab
  get Overview() {
    return this.addDrinkForm.controls.Overview as FormGroup;
  }
  get DrinkType(){
    return this.Overview.controls.DrinkType as FormControl;
  }
  get Name(){
    return this.Overview.controls.Name as FormControl;
  }
  get Style(){
    return this.Overview.controls.Style as FormControl;
  }
  get Price(){
    return this.Overview.controls.Price as FormControl;
  }
  get Size(){
    return this.Overview.controls.Size as FormControl;
  }
  get Alcohol(){
    return this.Overview.controls.Alcohol as FormControl;
  }
  get Company(){
    return this.Overview.controls.Company as FormControl;
  }
  get CompanyLocation(){
    return this.Overview.controls.CompanyLocation as FormControl;
  }

  //price tab
  get About() {
    return this.addDrinkForm.controls.About as FormGroup;
  }
  get Description(){
    return this.About.controls.Description as FormControl;
  }

  mapDrink(): void {
    this.idrink.drinkType = +this.DrinkType.value;
    this.idrink.name = this.Name.value;
    this.idrink.style = this.Style.value;
    this.idrink.price = +this.Price.value;
    this.idrink.sizeInMl = +this.Size.value;
    this.idrink.alcContent = +this.Alcohol.value;
    this.idrink.company = this.Company.value;
    this.idrink.companyLocation = this.CompanyLocation.value;
    this.idrink.description = this.Description.value;
    this.idrink.image = this.imageUploadResponse.dbPath;
  }

  public uploadFinished = (event) => {
    this.imageUploadResponse = event;
    this.drinkView.image = this.imageUploadResponse.dbPath;
  }


  selectTab(tabId: number, isCurrentTabValid: boolean) {
    this.nextClicked = true;
    if(isCurrentTabValid){
      this.formTabs.tabs[tabId].active = true;
    }
  }

  onCreate(){
    console.log("Not sure what to do here yet!");
  }
}
