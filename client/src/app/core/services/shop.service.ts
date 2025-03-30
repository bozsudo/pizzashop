import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Pizza } from '../../shared/models/pizza';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = 'http://localhost:5000/api/';
  private http = inject(HttpClient);
  getPizzas() {
    return this.http.get<Pizza[]>(this.baseUrl + 'pizzas');
  }
}
