import { Component, inject, OnInit } from '@angular/core';
import { ShopService } from '../../core/services/shop.service';
import { Pizza } from '../../shared/models/pizza';

@Component({
  selector: 'app-shop',
  standalone: true,
  imports: [],
  templateUrl: './shop.component.html',
  styleUrl: './shop.component.css'
})
export class ShopComponent implements OnInit {
  private ShopService = inject(ShopService);
  pizzas?: Array<Pizza>;

  ngOnInit(): void {
    this.initializeShop();
  }

  initializeShop() {
    this.getPizzas();
  }

  getPizzas() {
    this.ShopService.getPizzas().subscribe({
      next: response => this.pizzas = response,
      error: error => console.log(error),
    })
  }
}
