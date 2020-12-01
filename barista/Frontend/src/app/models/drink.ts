import { IDrink } from './idrink';

export class Drink implements IDrink {
  id: string;
  drinkType: number;
  name: string;
  style: string;
  sizeInMl: number;
  alcContent: number;
  price: number;
  company: string;
  companyLocation: string;
  description: string;
  image?: string;

}
