import { RecursoComponent } from './recurso/recurso.component';
import { Routes, RouterModule } from "@angular/router";

import { HomeComponent } from './home/home.component';
import { ModuleWithProviders } from "@angular/core";

const APP_ROUTES: Routes = [
    { path: 'recursos', component: RecursoComponent },
    { path: '', component: HomeComponent }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(APP_ROUTES);

