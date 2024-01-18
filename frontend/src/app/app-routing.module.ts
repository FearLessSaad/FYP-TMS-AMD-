import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: 'auth', loadChildren: () => import('./Pages/auth/auth.module').then(mod=>mod.AuthModule) },
  {path: 'dashboard', loadChildren: () => import('./Pages/dashboard/dashboard.module').then(mod=>mod.DashboardModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
