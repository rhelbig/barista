import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  transform(val: any[], filterString: string, propName: string): any[] {
    const resultArray = [];
    if(val === undefined || val.length === 0 || filterString === '' || propName === ''){
      return val;
    }
    for(const item of val) {
      if(item[propName] && item[propName].toString() === filterString) {
        resultArray.push(item);
      }
    }
    return resultArray;
  }

}
