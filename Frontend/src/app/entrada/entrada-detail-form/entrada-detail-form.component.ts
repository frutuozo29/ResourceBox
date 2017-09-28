import { RecursoService } from './../../recurso/services/recurso.service';
import { Component, OnInit } from '@angular/core';

import { RecursoEntrada } from './../shares/RecursoEntrada';
import { EntradaFormService } from './../services/entrada-form.service';

@Component({
  selector: 'app-entrada-detail-form',
  templateUrl: './entrada-detail-form.component.html',
  styleUrls: ['./entrada-detail-form.component.css']
})
export class EntradaDetailFormComponent implements OnInit {

  recursoEntrada: RecursoEntrada = new RecursoEntrada();

  constructor(
    private recursoService: RecursoService,
    private entradaFormService: EntradaFormService
  ) { }

  ngOnInit() {
  }

  save(f) {
    this.entradaFormService.novoRecusoEntrada(this.recursoEntrada);
  }

}
