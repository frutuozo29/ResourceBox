import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { Responsavel } from './shared/responsavel';
import { ResponsavelService } from './services/responsavel.service';

@Component({
  selector: 'app-responsavel',
  templateUrl: './responsavel.component.html',
  styleUrls: ['./responsavel.component.css']
})
export class ResponsavelComponent implements OnInit {

  responsaveis: Responsavel[] = [];
  
  constructor(
    private router: Router,
    private responsavelService: ResponsavelService
  ) { }

  ngOnInit() {
    this.responsavelService.getResponsaveis()
      .subscribe(data => {        
        this.responsaveis = data
      });
  }

  novo() {
    this.router.navigate(['responsavel/novo']);
  }

  delete(responsavel) {
    if (confirm("Tem certeza de que deseja excluir " + responsavel.Nome + "?")) {
      var index = this.responsaveis.indexOf(responsavel);
      this.responsaveis.splice(index, 1);

      let result = this.responsavelService.deleteResponsavel(responsavel.Id);
      result.subscribe(data => this.router.navigate(['responsavel']),
        err => {
          alert("Não foi possível excluir o responsável.");
          this.responsaveis.splice(index, 0, responsavel);
        });
    }
  }

}
