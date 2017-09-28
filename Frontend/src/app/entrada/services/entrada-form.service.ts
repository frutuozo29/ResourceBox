import { Injectable, EventEmitter } from '@angular/core';

import { RecursoEntrada } from './../shares/RecursoEntrada';

@Injectable()
export class EntradaFormService {

  emitirNovaEntrada = new EventEmitter<RecursoEntrada>();

  constructor() { }

  novoRecusoEntrada(recursoEntrada: RecursoEntrada) {
    this.emitirNovaEntrada.emit(recursoEntrada);
  }

}
