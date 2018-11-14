import { Injectable } from "@angular/core";
import { Http, Response, Headers } from "@angular/http";
import { Observable } from "rxjs";
import { Produto } from "./produto";
import 'rxjs/add/operator/map';
import { Order, OrderItem } from "./order";

@Injectable()
export class ServicoDados {

  constructor(private http: Http) {

  }

  private token: string = "";
  private tokenExpiration: Date;

  //public order: Order = new Order();

  public produtos: Produto[] = [];

  public carregaProdutos(): Observable<Produto[]> {
    return this.http.get("http://localhost:8585/api/produto")
      .map((result: Response) => this.produtos = result.json());
  }

  //public get loginRequired(): boolean {
  //  return this.token.length == 0 || this.tokenExpiration > new Date();
  //}

  //public login(creds) {
  //  return this.http.post("/account/createtoken", creds)
  //    .map(response => {
  //      let tokenInfo = response.json();
  //      this.token = tokenInfo.token;
  //      this.tokenExpiration = tokenInfo.expiration;
  //      return true;
  //    });
  //}

  //public checkout() {
  //  if (!this.order.orderNumber) {
  //    this.order.orderNumber = this.order.orderDate.getFullYear().toString() + this.order.orderDate.getTime().toString();
  //  }

  //  return this.http.post("/api/orders", this.order, {
  //    headers: new Headers({ "Authorization": "Bearer " + this.token })
  //  })
  //    .map(response => {
  //      this.order = new Order();
  //      return true;
  //    });
  //}

  //public AddToOrder(product: Product) {

  //  let item: OrderItem = this.order.items.find(i => i.productId == product.id);

  //  if (item) {

  //    item.quantity++;

  //  } else {

  //    item = new OrderItem();
  //    item.productId = product.id;
  //    item.productArtist = product.artist;
  //    item.productCategory = product.category;
  //    item.productArtId = product.artId;
  //    item.productTitle = product.title;
  //    item.productSize = product.size;
  //    item.unitPrice = product.price;
  //    item.quantity = 1;

  //    this.order.items.push(item);
  //  }
  //}


}
