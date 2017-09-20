import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { RecursoComponent } from './recurso/recurso.component';
import { RecursoFormComponent } from './recurso/recurso-form/recurso-form.component';
import { ResponsavelComponent } from './responsavel/responsavel.component';
import { ResponsavelFormComponent } from './responsavel/responsavel-form/responsavel-form.component';
import { EntradaComponent } from './entrada/entrada.component';

const routes: Routes = [
  { path: 'recurso', component: RecursoComponent },
  { path: 'recurso/form', component: RecursoFormComponent },
  { path: 'recurso/:id', component: RecursoFormComponent },
  { path: 'responsavel', component: ResponsavelComponent },
  { path: 'responsavel/form', component: ResponsavelFormComponent },
  { path: 'responsavel/:id', component: ResponsavelFormComponent },
  { path: 'entrada', component: EntradaComponent },
  { path: '', component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
