import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { Http, HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BsDropdownModule } from 'ngx-bootstrap';
import { RecursoComponent } from './recurso/recurso.component';
import { HomeComponent } from './home/home.component';
import { RecursoFormComponent } from './recurso/recurso-form/recurso-form.component';
import { RecursoService } from './recurso/recurso.service';

@NgModule({
  declarations: [
    AppComponent,
    RecursoComponent,
    HomeComponent,
    RecursoFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpModule,
    BsDropdownModule.forRoot()
  ],
  providers: [RecursoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
