import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';

import { RecursoEntrada } from './../shares/RecursoEntrada';

@Component({
  selector: 'app-entrada-detail',
  templateUrl: './entrada-detail.component.html',
  styleUrls: ['./entrada-detail.component.css']
})
export class EntradaDetailComponent implements OnInit {

  @Input() recursosEntrada: RecursoEntrada[];

  constructor(
    private router: Router
  ) { }

  ngOnInit() {
  }

  novo() {
    this.router.navigate(['entrada/novo/recursoentrada/novo']);
  }

}
