var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '@angular/core';
import { GridModule, ExcelModule } from '@progress/kendo-angular-grid';
import { DropDownsModule, DropDownListModule } from '@progress/kendo-angular-dropdowns';
import { DateInputsModule } from '@progress/kendo-angular-dateinputs';
import { IntlModule } from '@progress/kendo-angular-intl';
import { UploadModule } from '@progress/kendo-angular-upload';
import { PDFExportModule } from "@progress/kendo-angular-pdf-export";
import { PopupModule } from '@progress/kendo-angular-popup';
import { TreeViewModule } from '@progress/kendo-angular-treeview';
var kendoModules = [
    GridModule,
    DropDownsModule,
    DateInputsModule,
    ExcelModule,
    IntlModule,
    DropDownListModule,
    UploadModule,
    PDFExportModule,
    PopupModule,
    TreeViewModule
];
var KendoModule = /** @class */ (function () {
    function KendoModule() {
    }
    KendoModule = __decorate([
        NgModule({
            imports: kendoModules,
            exports: kendoModules
        })
    ], KendoModule);
    return KendoModule;
}());
export { KendoModule };
//# sourceMappingURL=kendo.module.js.map