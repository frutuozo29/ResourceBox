import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';

import { RecursoEntrada } from './../shares/RecursoEntrada';
import { EntradaService } from './../services/entrada.service';
import { Entrada } from './../shares/Entrada';

@Component({
  selector: 'app-entrada-detail',
  templateUrl: './entrada-detail.component.html',
  styleUrls: ['./entrada-detail.component.css']
})
export class EntradaDetailComponent implements OnInit {

  @Input() recursosEntrada: RecursoEntrada[];

  entrada: Entrada;

  constructor(
    private router: Router,
    private entradaService: EntradaService
  ) { }

  ngOnInit() {
  }

  novo() {
    this.router.navigate(['entrada/novo/recursoentrada/novo']);
  }

}
