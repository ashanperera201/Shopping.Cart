import { Routes, RouterModule } from '../shared/utilities/angular'
import { AuthComponent } from './auth.comonent';

const authRoutes: Routes = [
  {
    path: '', component: AuthComponent  
  },
]

export const AuthenticationMainRoutes = RouterModule.forChild(authRoutes);
