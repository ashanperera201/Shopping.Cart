import { RouterModule } from '../../shared/utilities/angular';
import { ProductComponent } from './product.component';
import { ProductLandingComponent } from './landing/landing.component';
var productRoutes = [
    {
        path: '', component: ProductComponent,
        children: [
            { path: '', redirectTo: 'landing', pathMatch: 'full' },
            { path: 'landing', component: ProductLandingComponent }
        ]
    },
];
export var ProductMainRoutes = RouterModule.forChild(productRoutes);
//# sourceMappingURL=product.route.js.map