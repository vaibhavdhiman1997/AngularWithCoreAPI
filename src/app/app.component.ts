import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from './_models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  

  ngOnInit(){
    this.setCurrentUser();
    this._hhtp.get("https://maps.googleapis.com/maps/api/timezone/json?location=39.6034810,-119.6822510&timestamp=1331161200&key=AIzaSyA0vz8JDrlCdbGZAv5jjwR1WFy9GgPz0Gw").subscribe(resp => {
      console.log(resp);
    })

  }
  constructor(private accountService: AccountService, private _hhtp: HttpClient){}
  title = 'AngularDatingWeb';

  setCurrentUser(){
    const user: User = JSON.parse(localStorage.getItem('user'));
    this.accountService.setCurrentUser(user);
  }


}
