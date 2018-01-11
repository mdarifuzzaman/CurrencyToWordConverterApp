import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { Constants } from '../models/constants';

@Injectable()
export class HttpUtilityService {

  private langTranslation;
  private _currentCulture: string;

  constructor(private http: Http) { }

  getJsonRequest(model): Promise<any> {
    const url = Constants.GET_URL + "?name=" + model.name + "&currency="+model.currency;
    return this.http.get(url).toPromise().then(response =>{
      return response;
    });
  }
  
}
