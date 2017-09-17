import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { RecursoComponent } from './recurso/recurso.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: 'recurso', component: RecursoComponent },
  { path: '', component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
