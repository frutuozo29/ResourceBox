import { EntradaDetailComponent } from './entrada/entrada-detail/entrada-detail.component';
import { EntradaDetailFormComponent } from './entrada/entrada-detail-form/entrada-detail-form.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { RecursoComponent } from './recurso/recurso.component';
import { RecursoFormComponent } from './recurso/recurso-form/recurso-form.component';
import { ResponsavelComponent } from './responsavel/responsavel.component';
import { ResponsavelFormComponent } from './responsavel/responsavel-form/responsavel-form.component';
import { EntradaComponent } from './entrada/entrada.component';
import { EntradaFormComponent } from './entrada/entrada-form/entrada-form.component';

const routes: Routes = [
  { path: 'recurso', component: RecursoComponent },
  { path: 'recurso/novo', component: RecursoFormComponent },
  { path: 'recurso/:id', component: RecursoFormComponent },
  { path: 'responsavel', component: ResponsavelComponent },
  { path: 'responsavel/novo', component: ResponsavelFormComponent },
  { path: 'responsavel/:id', component: ResponsavelFormComponent },
  { path: 'entrada', component: EntradaComponent },
  { path: 'entrada/novo', component: EntradaFormComponent, children: [
    { path: 'recursoentrada/novo', component: EntradaDetailFormComponent },
    { path: 'recursoentrada/:id', component: EntradaDetailFormComponent },
    { path: '', component: EntradaDetailComponent }
  ]},
  { path: 'entrada/:id', component: EntradaFormComponent },  
  { path: '', component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
