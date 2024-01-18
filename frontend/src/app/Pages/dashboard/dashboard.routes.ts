import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { DepartmentHeadComponent } from './department-head/department-head.component';
import { TeacherComponent } from './teacher/teacher.component';


const routes: Routes = [
  {path: 'admin', component: AdminComponent},
  {path: 'head', component: DepartmentHeadComponent},
  {path: 'teacher', component: TeacherComponent},

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
