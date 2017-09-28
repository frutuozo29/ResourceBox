import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { Http, HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BsDropdownModule } from 'ngx-bootstrap';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { RecursoComponent } from './recurso/recurso.component';
import { HomeComponent } from './home/home.component';
import { RecursoFormComponent } from './recurso/recurso-form/recurso-form.component';
import { RecursoService } from './recurso/services/recurso.service';
import { ResponsavelComponent } from './responsavel/responsavel.component';
import { ResponsavelFormComponent } from './responsavel/responsavel-form/responsavel-form.component';
import { ResponsavelService } from './responsavel/services/responsavel.service';
import { EntradaModule } from './entrada/entrada.module';
import { EntradaService } from './entrada/services/entrada.service';

@NgModule({
  declarations: [
    AppComponent,
    RecursoComponent,
    HomeComponent,
    RecursoFormComponent,
    ResponsavelComponent,
    ResponsavelFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    BsDropdownModule.forRoot(),
    CollapseModule.forRoot(),
    EntradaModule,
    AppRoutingModule
  ],
  providers: [RecursoService, ResponsavelService, EntradaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
