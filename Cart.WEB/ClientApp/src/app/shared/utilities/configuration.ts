import { Injectable } from "../utilities/angular";
import * as config from "../../../assets/configuration/config.json"
import appSettings from "../../../../../appsettings.json"


@Injectable()
export class Configuration {

  public configFileObject: any;
  public appSettings: any;
  public enFileObject: any;

  public static readonly ConfigList: any = config;

  //Main APIs
  public server: any;
  public apiUrl: any;
  public serverWithApiUrl: any;

  //Controllers
  public products: any;

  //Methods
  public findRole: any;


  constructor() {
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

}
