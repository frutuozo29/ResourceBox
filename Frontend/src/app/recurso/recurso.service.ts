import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions } from '@angular/http';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import { Observable } from 'rxjs/Rx';

@Injectable()
export class RecursoService {

  url: string = "http://localhost:58492/api/recurso";

  constructor(private http: Http) { }

  getRecursos() {
    return this.http.get(this.url)
      .map(res => res.json());
  }

  getRecurso(id){
    return this.http.get(this.getRecursoUrl(id))
      .map(res => res.json());
  }

  addRecurso(recurso){
    let body = JSON.stringify(recurso);
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    return this.http.post(this.url, body, options)
      .map(res => res.json());
  }

  updateRecurso(recurso){
    let body = JSON.stringify(recurso);
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    return this.http.put(this.getRecursoUrl(recurso.id), body, options)
      .map(res => res.json());
  }

  deleteRecurso(id){
    return this.http.delete(this.getRecursoUrl(id))
      .map(res => res.json());
  }

  private getRecursoUrl(id){
    return this.url + "/" + id;
  }
}
