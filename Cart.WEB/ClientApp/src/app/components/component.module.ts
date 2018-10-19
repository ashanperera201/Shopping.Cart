import { NgModule, CommonModule, RouterModule } from "../shared/utilities/angular"
import { NavComponent } from "./nav/nav.component";
import { HeaderComponent } from "../components/header/header.component";


@NgModule({
  imports: [
    CommonModule,
    RouterModule
  ],
  declarations: [
    HeaderComponent,
    NavComponent,
  ],
  exports: [
    CommonModule,
    NavComponent,
    HeaderComponent
  ]
})

export class ComponentsModule {
  constructor() { }
}
