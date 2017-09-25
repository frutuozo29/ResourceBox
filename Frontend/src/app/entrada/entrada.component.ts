import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { Entrada } from './shares/Entrada';
import { EntradaService } from './services/entrada.service';

@Component({
  selector: 'app-entrada',
  templateUrl: './entrada.component.html',
  styleUrls: ['./entrada.component.css']
})
export class EntradaComponent implements OnInit {

  entradas: Entrada[] = []

  constructor(
    private router: Router,
    private entradaService: EntradaService
  ) { }

  ngOnInit() {
    this.entradaService.getEntradas()
    .subscribe(data => {        
      this.entradas = data
    });
  }

  novo() {
    this.router.navigate(['entrada/novo']);
  }

  delete(entrada) {
    if (confirm("Tem certeza de que deseja excluir " + entrada.Data + " - " + entrada.ResponsavelNome + "?")) {
      var index = this.entradas.indexOf(entrada);
      this.entradas.splice(index, 1);

      let result = this.entradaService.deleteEntrada(entrada.Id);
      result.subscribe(data => this.router.navigate(['entrada']),
        err => {
          alert("Não foi possível excluir a Entrada.");
          this.entradas.splice(index, 0, entrada);
        });
    }
  }

}
