import { Component, OnInit } from "@angular/core";
import { ServicoDados } from '../compartilhado/servicoDados';
import { Produto } from "../compartilhado/produto";

@Component({
  selector: "lista-Produtos",
  templateUrl: "listaProdutos.component.html",
  styleUrls: ["listaProdutos.component.css"]
})
export class ListaProdutos  implements OnInit {

  public produtos: Produto[];

  constructor(private data: ServicoDados) {
    this.produtos = data.produtos;
  }

  ngOnInit() {
    this.data.carregaProdutos()
      .subscribe(() => this.produtos = this.data.produtos);
  }

  //addProduct(product: Product) {
  //  this.data.AddToOrder(product);
  //}
}
