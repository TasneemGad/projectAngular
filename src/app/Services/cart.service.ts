import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import {catchError} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CartService { 

}


// .pipe(catchError((err)=>{
//   return throwError(err.message || 'error Happen')
// }))