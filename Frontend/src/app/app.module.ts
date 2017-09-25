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
import { EntradaComponent } from './entrada/entrada.component';
import { ResponsavelComponent } from './responsavel/responsavel.component';
import { ResponsavelFormComponent } from './responsavel/responsavel-form/responsavel-form.component';
import { ResponsavelService } from './responsavel/services/responsavel.service';
import { EntradaFormComponent } from './entrada/entrada-form/entrada-form.component';
import { EntradaDetailComponent } from './entrada/entrada-detail/entrada-detail.component';
import { EntradaService } from './entrada/services/entrada.service';
import { FormDebugComponent } from './form-debug/form-debug.component';
import { EntradaDetailFormComponent } from './entrada/entrada-detail-form/entrada-detail-form.component';

@NgModule({
  declarations: [
    AppComponent,
    RecursoComponent,
    HomeComponent,
    RecursoFormComponent,
    EntradaComponent,
    ResponsavelComponent,
    ResponsavelFormComponent,
    EntradaFormComponent,
    EntradaDetailComponent,
    FormDebugComponent,
    EntradaDetailFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpModule,
    BsDropdownModule.forRoot(),
    CollapseModule.forRoot()
  ],
  providers: [RecursoService, ResponsavelService, EntradaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
