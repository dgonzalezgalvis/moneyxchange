import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class CalculateService {
  url = 'http://localhost:59915/api/Exchanges/';
  constructor(private _http: HttpClient) { }

  getChangeRate(from, to) {
    return this._http.get<any>(this.url + from + '/' + to);
  }
}
