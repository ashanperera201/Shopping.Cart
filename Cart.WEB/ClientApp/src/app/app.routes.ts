import { Routes, RouterModule } from './shared/utilities/angular'

const cartMainModuleRouting: Routes = [
  { path: '', redirectTo: 'app-site', pathMatch: 'full' },
  { path: 'app-site', loadChildren: './site/site.module#SiteModule' }
  //{ path: '', redirectTo: '/auth/login', pathMatch: 'full' },
  //{ path: 'auth', loadChildren: './login/login.module#LoginModule' },
  //{ path: 'dashboard', loadChildren: './dashboard/dashboard.module#DashboardModule' }
]


export const AppCartRoutings = RouterModule.forRoot(cartMainModuleRouting, { useHash: false })
