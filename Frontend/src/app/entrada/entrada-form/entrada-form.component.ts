import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import * as moment from 'moment'
import { Entrada } from './../shares/Entrada';
import { EntradaService } from './../services/entrada.service';
import { Responsavel } from './../../responsavel/shared/responsavel';
import { ResponsavelService } from './../../responsavel/services/responsavel.service';

@Component({
  selector: 'app-entrada-form',
  templateUrl: './entrada-form.component.html',
  styleUrls: ['./entrada-form.component.css']
})
export class EntradaFormComponent implements OnInit {

  responsaveis: Responsavel[] = [];
  entrada: Entrada = new Entrada();
  responsavel: any = {};

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private entradaService: EntradaService,
    private responsavelService: ResponsavelService
  ) { }

  ngOnInit() {    
    var id = this.route.snapshot.params['id'];
    this.popularDropDownResponsaveis();

    if (!id) 
      return;
    
    this.entradaService.getEntrada(id)
      .subscribe(
      entrada => this.entrada = entrada,
      response => {
        if (response.status == 404) {
          this.router.navigate(['']);
        }
      });
  }

  save(form) {
    let result;
    let entradaValue = this.entrada;
    if (entradaValue.Id) {
      result = this.entradaService.updateEntrada(entradaValue);
    } else {
      result = this.entradaService.addEntrada(entradaValue);
    }

    result.subscribe(data => this.router.navigate(['entrada']));
  }

  cancel() {
    this.router.navigate(['entrada']);
  }

  private popularDropDownResponsaveis() {
    this.responsavelService.getResponsaveis()
      .subscribe(
      responsaveis => this.responsaveis = responsaveis,
      response => {
        if (response.status == 404) {
          this.router.navigate(['']);
        }
      });
  }
}
