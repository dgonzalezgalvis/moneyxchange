import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import {LoginService} from '../../services/login/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  username = '';
  password = '';
  constructor(private _router: Router,
            private _login: LoginService) { }

  ngOnInit() {
  }

  login() {
    // if(this.username === 'Diego' && this.password === '1234') {
    //   this._router.navigate(['/exchange']);
    // }
    this._login.login(this.username, this.password).subscribe(response=>{
      console.log(response);
      this._router.navigate(['/exchange']);
    });
  }

}
