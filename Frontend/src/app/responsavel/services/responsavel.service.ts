import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions } from '@angular/http';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import { Observable } from 'rxjs/Rx';

@Injectable()
export class ResponsavelService {

  url: string = "http://localhost:58492/api/responsavel";

  constructor(private http: Http) { }

  getResponsaveis() {
    return this.http.get(this.url)
      .map(res => res.json());
  }

  getResponsavel(id){
    return this.http.get(this.getResponsavelUrl(id))
      .map(res => res.json());
  }

  addResponsavel(responsavel){
    let body = JSON.stringify(responsavel);
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    return this.http.post(this.url, body, options)
      .map(res => res.json());
  }

  updateResponsavel(responsavel){
    let body = JSON.stringify(responsavel);
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    return this.http.put(this.getResponsavelUrl(responsavel.Id), body, options)
      .map(res => res.json());
  }

  deleteResponsavel(id){
    return this.http.delete(this.getResponsavelUrl(id))
      .map(res => res.json());
  }

  private getResponsavelUrl(id){
    return this.url + "/" + id;
  }
}
