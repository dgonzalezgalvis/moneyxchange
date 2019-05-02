import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';


import { AppComponent } from './app.component';

import { CalculateService } from './services/calculate/calculate.service';
import { LoginService } from './services/login/login.service';
import { ExchangeComponent } from './components/exchange/exchange.component';
import { LoginComponent } from './components/login/login.component';

import { AppRoutingModule } from './app-routing.module';


@NgModule({
  declarations: [
    AppComponent,
    ExchangeComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [
    CalculateService,
    LoginService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
