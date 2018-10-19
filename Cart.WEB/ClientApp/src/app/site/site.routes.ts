import { Routes, RouterModule } from '../shared/utilities/angular'
import { SiteComponent } from './site.component';


const siteRoutes: Routes = [
  {
    path: '', component: SiteComponent,
    children: [
      { path: '', redirectTo: 'product', pathMatch: 'full' },
      { path: 'product', loadChildren: './products/product.module#ProductModule' },
    ]
  },
]

export const SiteMainRoutes = RouterModule.forChild(siteRoutes);
