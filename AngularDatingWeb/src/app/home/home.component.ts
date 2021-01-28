import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registerModel: boolean = false;
  constructor() { }

  ngOnInit(): void { 
  }

  registerToggle(){
    this.registerModel = !this.registerModel;
  }

  // GetUsers(){
  //   this._http.get("https://localhost:5001/api/Users/GetUsers").subscribe(
  //     resp => {
  //       this.users = resp;        
  //     }
  //   ), (err) => {
  //     console.log(err);
      
  //   }
  // }

  cancelRegisterMode(event: boolean){ 
    this.registerModel = event;
  }
}
