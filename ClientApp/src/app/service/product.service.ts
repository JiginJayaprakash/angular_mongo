import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../models/product.model';

const baseUrl = 'https://special-guacamole-pjrqvqxpw6xrf9w7-5134.app.github.dev/Product';

@Injectable({
  providedIn:'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Product[]> {
    //let a = 'https://super-garbanzo-7v94q4gp5wp7cpqrv-5134.app.github.dev/WeatherForecast';
    return this.http.get<Product[]>(baseUrl);
  }

  create(data: any): Observable<any> {
    return this.http.post(baseUrl, data);
  }

  delete(id: any): Observable<any> {
    return this.http.delete(`${baseUrl}/${id}`);
  }
}
