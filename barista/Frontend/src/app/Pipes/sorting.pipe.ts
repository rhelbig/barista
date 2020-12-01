import { analyzeAndValidateNgModules } from '@angular/compiler';
import { ValueConverter } from '@angular/compiler/src/render3/view/template';
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'sorting'
})
export class SortingPipe implements PipeTransform {


  transform(val: Array<string>, sortField: string, descending?: boolean): any[] {
    if(val === undefined || val.length === 0 || sortField === ''){
      return val;
    }
    let ascDesc = 1;
    if(descending) {
      ascDesc = -1;
    }
    val.sort((a: any, b: any) => {
      if(a[sortField] < b[sortField]){
        return -1 * ascDesc;
      } else if (a[sortField] > b[sortField]) {
        return 1 * ascDesc;
      } else {
        return 0;
      }
    }
    );

    return val;
  }

}
