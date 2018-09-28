import { Pipe, PipeTransform } from '@angular/core';
import { UserService } from './shared/user.service';
import { User } from './shared/user.model';
@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  transform(value: any, text: string): any {
    if(!text){
      return value;
    }
    return value.filter (x => x.Firstname.toLowerCase().indexOf(text.toLowerCase())>-1)
  }
}

