import { Responsavel } from './../../responsavel/shared/responsavel';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-entrada-form',
  templateUrl: './entrada-form.component.html',
  styleUrls: ['./entrada-form.component.css']
})
export class EntradaFormComponent implements OnInit {

  responsaveis: Responsavel[] = [];
  selectedRepresentante: any = {};

  constructor() { 
    var responsavel1 = new Responsavel();
    responsavel1.Id = 1;
    responsavel1.Nome = "Renan";
    this.responsaveis.push(responsavel1);
    var responsavel2 = new Responsavel();
    responsavel2.Id = 2;
    responsavel2.Nome = "Rodolffo";
    this.responsaveis.push(responsavel2);
    var responsavel3 = new Responsavel();
    responsavel3.Id = 3;
    responsavel3.Nome = "Rayane";
    this.responsaveis.push(responsavel3);
    var responsavel4 = new Responsavel();
    responsavel4.Id = 4;
    responsavel4.Nome = "Pai/Mãe";
    this.responsaveis.push(responsavel4);
  }

  ngOnInit() {
  }

  salvar(selectOption){
    console.log(selectOption.option.value);
    console.log(this.selectedRepresentante)
  }

  onChange(event){
    console.log(event)
  }

}
