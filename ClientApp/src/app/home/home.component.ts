import { Component } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { ProductService } from 'src/app/service/product.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
product: Product = {
    description: ''
  };
  
  constructor(private productService: ProductService) { }
 
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
