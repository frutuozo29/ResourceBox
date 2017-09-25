import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";

import { RecursoService } from './services/recurso.service';
import { Recurso } from './shared/recurso';


@Component({
  selector: 'app-recurso',
  templateUrl: './recurso.component.html',
  styleUrls: ['./recurso.component.css']
})
export class RecursoComponent implements OnInit {

  recursos: Recurso[] = [];

  constructor(
    private router: Router,
    private recursoService: RecursoService) { }

  ngOnInit() {
    this.recursoService.getRecursos()
      .subscribe(data => {
        this.recursos = data;
      })
  }

  novo() {
    this.router.navigate(['recurso/novo']);
  }

  delete(recurso) {
    if (confirm("Tem certeza de que deseja excluir " + recurso.Descricao + "?")) {
      var index = this.recursos.indexOf(recurso);
      this.recursos.splice(index, 1);

      let result = this.recursoService.deleteRecurso(recurso.Id);
      result.subscribe(data => this.router.navigate(['recurso']),
        err => {
          alert("Não foi possível excluir o recurso.");
          this.recursos.splice(index, 0, recurso);
        });
    }
  }
}
