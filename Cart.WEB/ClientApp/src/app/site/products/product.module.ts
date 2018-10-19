import { NgModule, CommonModule } from "../../shared/utilities/angular";
import { ProductComponent } from "./product.component";
import { ProductLandingComponent } from "./landing/landing.component";
import { ProductMainRoutes } from "./product.route";

@NgModule({
  imports: [
    CommonModule,
    ProductMainRoutes
  ],
  declarations: [
    ProductComponent,
    ProductLandingComponent
  ],
  exports: [
    CommonModule
  ]
})

export class ProductModule {
  constructor() { }
}

