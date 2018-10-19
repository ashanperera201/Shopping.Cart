import { NgModule, CommonModule } from '../shared/utilities/angular'
import { SiteMainRoutes } from './site.routes';
import { SiteComponent } from './site.component';
import { ComponentsModule } from '../components/component.module';

@NgModule({
  imports: [
    CommonModule,
    SiteMainRoutes,
    ComponentsModule
  ],
  exports: [

  ],
  declarations: [
    SiteComponent
  ],
  providers: [

  ]
})

export class SiteModule {

}
