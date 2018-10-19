import { Injectable, HttpClient } from "../../utilities/angular";
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';
import { Configuration } from "../../utilities/configuration";

@Injectable()
export class DataService {

  constructor(private http: HttpClient, public _configuration: Configuration) {

  }

  /**
  * Get All by Get.
  */
  public getAllByGet<T>(actionUrl: any): Observable<T> {
    const endpointUrl: string = this._configuration.serverWithApiUrl + actionUrl;
    return this.http.get<T>(endpointUrl)
      .map((response: T) => {
        return response;
      })
  }

  /**
  * Get all by Post.
  */
  public getAllByPost<T>(actionUrl: any, params: any): Observable<T> {
    const endpointUrl: string = this._configuration.serverWithApiUrl + actionUrl;
    return this.http.post<T>(endpointUrl, params)
      .map((response: T) => {
        return response;
      })
  }

  /**
   * Add.
   */
  public add<T>(actionUrl: any, object: any): Observable<T> {
    const endpointUrl: string = this._configuration.serverWithApiUrl + actionUrl;
    return this.http.post<T>(endpointUrl, object)
      .map((response: T) => {
        return response;
      })
  }

  /**
  * Update Put.
  */
  public updatePut<T>(actionUrl: any, object: any): Observable<T> {
    const endpointUrl: string = this._configuration.serverWithApiUrl + actionUrl;
    return this.http.put<T>(endpointUrl, object)
      .map((response: T) => {
        return response;
      })
  }

  /**
   * Update Patch.
   */
  public updatePatch<T>(actionUrl: any, object: any): Observable<T> {
    const endpointUrl: string = this._configuration.serverWithApiUrl + actionUrl;
    return this.http.patch<T>(endpointUrl, object)
      .map((response: T) => {
        return response;
      })
  }

  /**
  * Delete.
  */
  public delete<T>(actionUrl: any, object: any): Observable<T> {
    const endpointUrl: string = this._configuration.serverWithApiUrl + actionUrl;
    return this.http.delete<T>(endpointUrl + object.id)
      .map((response: T) => {
        return response;
      })
  }
}
