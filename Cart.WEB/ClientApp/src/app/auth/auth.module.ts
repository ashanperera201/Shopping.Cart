import { NgModule, CommonModule } from '../shared/utilities/angular'
import { MaterialModule } from '../shared/modules/material.module'
import { AuthComponent } from './auth.comonent'
import { AuthenticationMainRoutes } from './auth.route';


@NgModule({
  imports: [
    CommonModule,
    MaterialModule,
    AuthenticationMainRoutes
  ],
  declarations: [
    AuthComponent
  ],
  exports: [

  ],
  providers: [

  ]
})

export class AuthenticationModule {
  constructor() { }
}
