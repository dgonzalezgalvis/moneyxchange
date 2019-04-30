import { Component } from '@angular/core';
import { CalculateService } from './services/calculate.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'app';
  usdollars = 0;
  euros = 0;

  constructor(private _calculate: CalculateService) {

  }

  calculate() {
    console.log(this.usdollars);
    if (this.usdollars && this.usdollars > 0) {
      this.euros = this.usdollars * 2;
      this._calculate.getChangeRate('USD','EUR');
    }
  }

}
