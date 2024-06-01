import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AngajatiListComponent } from './components/angajati/angajati-list/angajati-list.component';

export const routes: Routes = [
    {
        path: 'angajati',
        component: AngajatiListComponent
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }