import { RouterModule } from '../shared/utilities/angular';
import { SiteComponent } from './site.component';
var siteRoutes = [
    {
        path: '', component: SiteComponent,
        children: [
            { path: 'product', loadChildren: './products/product.module#ProductModule' },
        ]
    },
];
export var SiteMainRoutes = RouterModule.forChild(siteRoutes);
//# sourceMappingURL=site.routes.js.map