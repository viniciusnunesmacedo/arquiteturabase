import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
//import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http'

import { AppComponent } from './app.component';
import { ListaProdutos } from './shop/listaProdutos.component';
import { Cart } from './shop/cart.component';
import { Shop } from './shop/shop.component';
import { Checkout } from './checkout/checkout.component';
import { Login } from './login/login.component';

import { ServicoDados } from "./compartilhado/servicoDados"

import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

let routes = [
  { path: "", component: Shop },
  { path: "checkout", component: Checkout },
  { path: "login", component: Login }
]

@NgModule({
  declarations: [
    AppComponent,
    ListaProdutos,
    Cart,
    Shop,
    Checkout,
    Login
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    //HttpClientModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot(routes, {
      useHash: true,
      enableTracing: false // para Debugging das rotas.
    })
  ],
  providers: [
    ServicoDados
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
