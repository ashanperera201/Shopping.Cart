var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Injectable, HttpClient } from "../../utilities/angular";
import 'rxjs/add/operator/map';
import { Configuration } from "../../utilities/configuration";
var DataService = /** @class */ (function () {
    function DataService(http, _configuration) {
        this.http = http;
        this._configuration = _configuration;
    }
    /**
    * Get All by Get.
    */
    DataService.prototype.getAllByGet = function (actionUrl) {
        var endpointUrl = this._configuration.serverWithApiUrl + actionUrl;
        return this.http.get(endpointUrl)
            .map(function (response) {
            return response;
        });
    };
    /**
    * Get all by Post.
    */
    DataService.prototype.getAllByPost = function (actionUrl, params) {
        var endpointUrl = this._configuration.serverWithApiUrl + actionUrl;
        return this.http.post(endpointUrl, params)
            .map(function (response) {
            return response;
        });
    };
    /**
     * Add.
     */
    DataService.prototype.add = function (actionUrl, object) {
        var endpointUrl = this._configuration.serverWithApiUrl + actionUrl;
        return this.http.post(endpointUrl, object)
            .map(function (response) {
            return response;
        });
    };
    /**
    * Update Put.
    */
    DataService.prototype.updatePut = function (actionUrl, object) {
        var endpointUrl = this._configuration.serverWithApiUrl + actionUrl;
        return this.http.put(endpointUrl, object)
            .map(function (response) {
            return response;
        });
    };
    /**
     * Update Patch.
     */
    DataService.prototype.updatePatch = function (actionUrl, object) {
        var endpointUrl = this._configuration.serverWithApiUrl + actionUrl;
        return this.http.patch(endpointUrl, object)
            .map(function (response) {
            return response;
        });
    };
    /**
    * Delete.
    */
    DataService.prototype.delete = function (actionUrl, object) {
        var endpointUrl = this._configuration.serverWithApiUrl + actionUrl;
        return this.http.delete(endpointUrl + object.id)
            .map(function (response) {
            return response;
        });
    };
    DataService = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient, Configuration])
    ], DataService);
    return DataService;
}());
export { DataService };
//# sourceMappingURL=data.service.js.map