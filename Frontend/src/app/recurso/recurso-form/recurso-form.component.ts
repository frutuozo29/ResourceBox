import { RecursoService } from './../recurso.service';
import { FormGroup } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { Recurso } from './../shared/recurso';

@Component({
  selector: 'app-recurso-form',
  templateUrl: './recurso-form.component.html',
  styleUrls: ['./recurso-form.component.css']
})
export class RecursoFormComponent implements OnInit {

  recurso: Recurso = new Recurso();
  form: FormGroup;

  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private recursoService: RecursoService) {
  }

  ngOnInit() {
    var id = this.route.snapshot.params['id'];
    if (!id)
      return;

    this.recursoService.getRecurso(id)
      .subscribe(
      recurso => this.recurso = recurso,
      response => {
        if (response.status == 404) {
          this.router.navigate(['']);
        }
      });
  }

  save(form) {
    let result;
    let recursoValue = form.value;       
    if (recursoValue.id) {
      result = this.recursoService.updateRecurso(recursoValue);
    } else {
      result = this.recursoService.addRecurso(recursoValue);
    }

    result.subscribe(data => this.router.navigate(['recurso']));
  }
}
