import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { RecursoComponent } from './recurso/recurso.component';
import { HomeComponent } from './home/home.component';
import { RecursoFormComponent } from './recurso/recurso-form/recurso-form.component';

const routes: Routes = [
  { path: 'recurso', component: RecursoComponent },
  { path: 'recurso/form', component: RecursoFormComponent },
  { path: 'recurso/:id', component: RecursoFormComponent },
  { path: '', component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
