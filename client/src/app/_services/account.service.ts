import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {map} from 'rxjs/operators';
import { User } from '../_models/user';
import { ReplaySubject } from 'rxjs';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = environment.APIUrl;
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
        /**return user; let you show the user when registered */
      })
    )
  }

  register(model: any){
    return this.http.post(this.baseUrl + 'account/register', model).pipe(
      map((user : User) => {
        if (user){
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
