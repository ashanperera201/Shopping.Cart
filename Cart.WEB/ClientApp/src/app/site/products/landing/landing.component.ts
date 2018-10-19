import { Component, Router, OnInit } from '../../../shared/utilities/angular'
import { DataService } from '../../../shared/services/global/data.service';
import { Configuration } from '../../../shared/utilities/configuration';
import { Product } from '../product.model';
import { debug } from 'util';

@Component({
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.css']
})

export class ProductLandingComponent implements OnInit {

  public products: Product[];

  constructor(public dataService: DataService, public configuration: Configuration, public router: Router) {
    this.products = [];
  }


  ngOnInit() {
    this.loadProductData();
  }

  private loadProductData(): void {
    const url: string = this.configuration.products + "products";
    this.dataService.getAllByGet(url).subscribe((data: any) => {
      if (!data.isError) {
        if (data.returnObject != []) {
          this.products = data.returnObject
        }
      }
    })
  }
}
