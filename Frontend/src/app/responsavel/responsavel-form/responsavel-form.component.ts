import { Router, ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';

import { Responsavel } from './../shared/responsavel';
import { ResponsavelService } from './../services/responsavel.service';

@Component({
  selector: 'app-responsavel-form',
  templateUrl: './responsavel-form.component.html',
  styleUrls: ['./responsavel-form.component.css']
})
export class ResponsavelFormComponent implements OnInit {

  responsavel: Responsavel = new Responsavel();
  form: FormGroup;

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private responsavelService: ResponsavelService) { }

  ngOnInit() {
    var id = this.route.snapshot.params['id'];
    if (!id)
      return;

    this.responsavelService.getResponsavel(id)
      .subscribe(
      responsavel => this.responsavel = responsavel,
      response => {
        if (response.status == 404) {
          this.router.navigate(['']);
        }
      });
  }

  save(form) {
    let result;
    let responsavelValue = form.value;
    if (responsavelValue.Id) {
      result = this.responsavelService.updateResponsavel(responsavelValue);
    } else {
      result = this.responsavelService.addResponsavel(responsavelValue);
    }

    result.subscribe(data => this.router.navigate(['responsavel']));
  }

  cancel() {
    this.router.navigate(['responsavel']);
  }
}
