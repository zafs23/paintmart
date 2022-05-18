import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from './models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'the paintmart app';
  users: any;

  constructor(private http: HttpClient, private accountService: AccountService) {}

  ngOnInit(): void{
    this.gerUsers();
    this.setCurrUser();
  }

  setCurrUser(){
    const user: User = JSON.parse(localStorage.getItem('user'));
    this.accountService.setCurrUser(user);
  }

  gerUsers(){
    this.http.get('https://localhost:5001/api/users').subscribe({
      next: response => this.users = response,
      error: error => console.log(error)
    })
  }
}
