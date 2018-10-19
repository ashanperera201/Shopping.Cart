var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Injectable } from "../utilities/angular";
import * as config from "../../../assets/configuration/config.json";
import appSettings from "../../../../../appsettings.json";
var Configuration = /** @class */ (function () {
    function Configuration() {
        this.configFileObject = config;
        this.appSettings = appSettings;
        //Main APIs
        this.server = this.appSettings.Configuration.Server;
        this.apiUrl = this.configFileObject.Shared.Configuration.ApiUrl;
        this.serverWithApiUrl = this.server + this.apiUrl;
        //Controllers
        this.products = this.configFileObject.Shared.Configuration.Controller.Product;
        //Methods
        //this.findRole = this.role + this.configFileObject.Shared.Configuration.Method.FindRoles;
    }
    Configuration.ConfigList = config;
    Configuration = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [])
    ], Configuration);
    return Configuration;
}());
export { Configuration };
//# sourceMappingURL=configuration.js.map