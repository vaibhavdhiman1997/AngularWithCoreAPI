import { Component, OnInit } from '@angular/core';
import  firebase from 'firebase/app';
import { WindowService } from '../window.service';
@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {
  windowRef: any;
  constructor(private win: WindowService) { }

  ngOnInit(): void {

    var app = firebase.initializeApp({
      apiKey: 'AIzaSyA0vz8JDrlCdbGZAv5jjwR1WFy9GgPz0Gw',
      // authDomain: '<your-auth-domain>',
      // projectId: '<your-cloud-firestore-project>',
      // storageBucket: '<your-storage-bucket>',
      // messagingSenderId: '<your-sender-id>'
    });

    this.windowRef = this.win.windowRef;
    this.windowRef.recaptchaVerifier = new firebase.auth.RecaptchaVerifier('recaptcha-container');
    this.windowRef.recaptchaVerifier.render();
  }


  clickMe(){
    const appVerifier = this.windowRef.recaptchaVerifier;
    const num = "+917017029604";
    firebase.auth().signInWithPhoneNumber(num, appVerifier)
            .then(result => {
                this.windowRef.confirmationResult = result;
            })
            .catch( error => console.log(error) );
  }
}
