import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class LoginService {
  url = 'http://localhost:59915/api/Logins/';
  constructor(private _http: HttpClient) { }

  login(username, password) {
    let bodyObj = {
      id: 1,
      username: username,
      password: password
    };
    return this._http.post<any>(this.url,bodyObj);
  }

}
