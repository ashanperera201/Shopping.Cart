var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '../utilities/angular';
import { MatInputModule, MatButtonModule, MatCheckboxModule, MatMenuModule, MatIconModule, MatDialogModule, MatToolbarModule, MatSelectModule, MatDatepickerModule, MatNativeDateModule, MatGridListModule, MatButtonToggleModule, MatAutocompleteModule, MatExpansionModule, MatCardModule, MatRadioModule, MatTableModule, MatTooltipModule, MatSidenavModule, MatTabsModule, MatChipsModule, MatListModule, MatStepperModule, MatSlideToggleModule } from '@angular/material';
var materialModules = [
    MatInputModule,
    MatButtonModule,
    MatCheckboxModule,
    MatMenuModule,
    MatIconModule,
    MatDialogModule,
    MatToolbarModule,
    MatSelectModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatGridListModule,
    MatButtonToggleModule,
    MatAutocompleteModule,
    MatExpansionModule,
    MatGridListModule,
    MatNativeDateModule,
    MatCardModule,
    MatRadioModule,
    MatTableModule,
    MatTooltipModule,
    MatSidenavModule,
    MatDialogModule,
    MatTabsModule,
    MatChipsModule,
    MatListModule,
    MatStepperModule,
    MatSlideToggleModule
];
var MaterialModule = /** @class */ (function () {
    function MaterialModule() {
    }
    MaterialModule = __decorate([
        NgModule({
            imports: materialModules,
            exports: materialModules
        })
    ], MaterialModule);
    return MaterialModule;
}());
export { MaterialModule };
//# sourceMappingURL=material.module.js.map