import { RouterModule } from './shared/utilities/angular';
var cartMainModuleRouting = [
    { path: '', redirectTo: 'app-site', pathMatch: 'full' },
    { path: 'app-site', loadChildren: './site/site.module#SiteModule' }
    //{ path: '', redirectTo: '/auth/login', pathMatch: 'full' },
    //{ path: 'auth', loadChildren: './login/login.module#LoginModule' },
    //{ path: 'dashboard', loadChildren: './dashboard/dashboard.module#DashboardModule' }
];
export var AppCartRoutings = RouterModule.forRoot(cartMainModuleRouting, { useHash: false });
//# sourceMappingURL=app.routes.js.map