import { Component, OnInit, NgModule } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { ProductService } from 'src/app/service/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
})

export class ProductComponent implements OnInit{
  product: Product = {
    description: ''
  };
  products?: Product[];

  constructor(private productService: ProductService) { }
  ngOnInit(): void {
    this.retrieveProducts();
  }
  retrieveProducts(): void {
    this.productService.getAll()
      .subscribe({
        next: (data) => {
          this.products = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }
  saveProduct(): void {
    const data = {
      description: this.product.description
    };

    this.productService.create(data)
      .subscribe({
        next: (res: boolean) => {
          console.log(res);
        },
        error: (e: any) => console.error(e)
      });
  }

  newProduct(): void {
    this.product = {
      description: ''
    };
  }
}
