import { Routes, RouterModule } from './shared/utilities/angular'

const cartMainModuleRouting: Routes = [
  { path: '', redirectTo: 'auth', pathMatch: 'full' },
  { path: 'app-site', loadChildren: './site/site.module#SiteModule' },  
  { path: 'auth', loadChildren: './auth/auth.module#AuthenticationModule' },
  //{ path: 'dashboard', loadChildren: './dashboard/dashboard.module#DashboardModule' }
]


export const AppCartRoutings = RouterModule.forRoot(cartMainModuleRouting, { useHash: false })
