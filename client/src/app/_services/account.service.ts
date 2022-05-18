import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {map} from 'rxjs/operators';
import { User } from '../models/user';
import { ReplaySubject } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = 'https://localhost:5001/api/';
  private currUserSource = new ReplaySubject<User>(1);
  currUser$ = this.currUserSource.asObservable();

  constructor(private http: HttpClient) { }

  login(model: any){
    return this.http.post(this.baseUrl + 'account/login', model).pipe(
      map((response: User) =>{
        const user = response;
        if(user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currUserSource.next(user);
        }
      })
    )
  }
    setCurrUser(user: User){
      this.currUserSource.next(user);
  }


  logout(){
    localStorage.removeItem('user');
    this.currUserSource.next(null);
  }


}
