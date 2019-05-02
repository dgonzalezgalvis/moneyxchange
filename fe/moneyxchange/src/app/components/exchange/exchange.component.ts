import { Component, OnInit } from '@angular/core';
import { CalculateService } from '../../services/calculate/calculate.service';
import { Subscription  } from 'rxjs';

@Component({
  selector: 'app-exchange',
  templateUrl: './exchange.component.html',
  styleUrls: ['./exchange.component.scss']
})
export class ExchangeComponent implements OnInit {
  title = 'app';
  usdollars = 0;
  euros = 0;
  rateFactor = 1;
  constructor(private _calculate: CalculateService) { }

  ngOnInit() {
    this._calculate.getChangeRate('USD', 'EUR').subscribe(response=>{
      this.rateFactor = response.factor;
    }) 
  }

  calculate() {
    console.log(this.usdollars);
    if (this.usdollars && this.usdollars > 0) {
      this.euros = this.usdollars * this.rateFactor;
      this._calculate.getChangeRate('USD','EUR');
    }
  }

}
