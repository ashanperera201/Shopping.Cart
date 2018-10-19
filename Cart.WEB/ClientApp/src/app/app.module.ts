import { BrowserModule } from '@angular/platform-browser';
import { NgModule, BrowserAnimationsModule, HttpClientModule } from './shared/utilities/angular';

import { SharedModule } from './shared/shared.module';
import { AppComponent } from './app.component';
import { AppCartRoutings } from './app.routes';
import { Configuration } from './shared/utilities/configuration';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppCartRoutings,
    SharedModule,
  ],
  providers: [Configuration],
  bootstrap: [AppComponent]
})
export class AppModule { }
