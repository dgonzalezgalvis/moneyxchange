import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable()
export class CalculateService {
  url = 'apiurl';
  constructor(private _http: HttpClient) { }

  getChangeRate(from, to) {
    this._http.get(this.url + '/base=' + from + '&symbols=' + to);
  }

}
