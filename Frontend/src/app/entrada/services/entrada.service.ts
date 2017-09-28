import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions } from '@angular/http';

import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import { Observable } from 'rxjs/Rx';
import { EventEmitter } from 'events';

@Injectable()
export class EntradaService {

  url: string = "http://localhost:58492/api/entrada";
  constructor(private http: Http) { }

  getEntradas() {
    return this.http.get(this.url)
      .map(res => res.json());
  }

  getEntrada(id) {
    return this.http.get(this.getEntradaUrl(id))
      .map(res => JSON.parse(res.text(), this.reviver));
  }

  reviver(key, value) {
    if (value === "timestamp") {
      return new Date(value);
    }
    return value;
  }

  addEntrada(entrada) {
    let body = JSON.stringify(entrada);
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    return this.http.post(this.url, body, options)
      .map(res => res.json());
  }

  updateEntrada(entrada) {
    let body = JSON.stringify(entrada);
    let headers = new Headers({ 'Content-Type': 'application/json' });
    let options = new RequestOptions({ headers: headers });
    return this.http.put(this.getEntradaUrl(entrada.Id), body, options)
      .map(res => res.json());
  }

  deleteEntrada(id) {
    return this.http.delete(this.getEntradaUrl(id))
      .map(res => res.json());
  }

  private getEntradaUrl(id) {
    return this.url + "/" + id;
  }
}
