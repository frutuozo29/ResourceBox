import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { EntradaComponent } from './entrada.component';
import { EntradaFormComponent } from './entrada-form/entrada-form.component';
import { EntradaDetailComponent } from './entrada-detail/entrada-detail.component';
import { EntradaDetailFormComponent } from './entrada-detail-form/entrada-detail-form.component';
import { FormDebugComponent } from './../form-debug/form-debug.component';

@NgModule({
    declarations: [
        EntradaComponent,
        EntradaFormComponent,
        EntradaDetailComponent,
        EntradaDetailFormComponent,
        FormDebugComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        BsDatepickerModule.forRoot()
    ],
    exports: [],
    providers: [],
})
export class EntradaModule { }