import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './views/home/home.component';
import { LoginComponent } from './views/login/login.component';
import { LojaComponent } from './views/loja/loja.component';
import { ServicosComponent } from './views/servicos/servicos.component';
import { NoticiasComponent } from './views/noticias/noticias.component';

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "login", component: LoginComponent},
  { path: "loja", component: LojaComponent},
  { path: "servicos", component: ServicosComponent},
  { path: "noticias", component: NoticiasComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
