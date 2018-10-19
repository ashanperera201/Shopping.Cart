var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule, CommonModule } from '../shared/utilities/angular';
import { SiteMainRoutes } from './site.routes';
import { SiteComponent } from './site.component';
import { ComponentsModule } from '../components/component.module';
var SiteModule = /** @class */ (function () {
    function SiteModule() {
    }
    SiteModule = __decorate([
        NgModule({
            imports: [
                CommonModule,
                SiteMainRoutes,
                ComponentsModule
            ],
            exports: [],
            declarations: [
                SiteComponent
            ],
            providers: []
        })
    ], SiteModule);
    return SiteModule;
}());
export { SiteModule };
//# sourceMappingURL=site.module.js.map