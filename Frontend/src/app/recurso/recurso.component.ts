import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { FormGroup } from "@angular/forms/forms";

import { RecursoService } from './recurso.service';
import { Recurso } from './shared/recurso';


@Component({
  selector: 'app-recurso',
  templateUrl: './recurso.component.html',
  styleUrls: ['./recurso.component.css']
})
export class RecursoComponent implements OnInit {

  private recursos: Recurso[] = [];
  form: FormGroup;
  
  constructor(
    private router: Router,
    private recursoService: RecursoService) { }

  ngOnInit() {
    this.recursoService.getRecursos()
      .subscribe(data => {
        this.recursos = data;
      })
  }

  novo(){    
    this.router.navigate(['recurso/form']);
  }

  delete(recurso){
    console.log(recurso);
    if (confirm("Tem certeza de que deseja excluir " + recurso.Descricao + "?")) {
      var index = this.recursos.indexOf(recurso);
      this.recursos.splice(index, 1);

      this.recursoService.deleteRecurso(recurso.Id)
        .subscribe(null,
          err => {
            alert("Não foi possível excluir o recurso.");            
            this.recursos.splice(index, 0, recurso);
          });
    }
  }
}
