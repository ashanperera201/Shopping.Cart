import { Routes, RouterModule } from '../../shared/utilities/angular'
import { ProductComponent } from './product.component';
import { ProductLandingComponent } from './landing/landing.component';


const productRoutes: Routes = [
  {
    path: '', component: ProductComponent,
    children: [
      { path: '', redirectTo: 'landing', pathMatch: 'full' },
      { path: 'landing', component: ProductLandingComponent }  
    ]
  },
]

export const ProductMainRoutes = RouterModule.forChild(productRoutes);
