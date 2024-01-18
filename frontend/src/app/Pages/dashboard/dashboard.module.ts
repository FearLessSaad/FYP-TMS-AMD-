import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardRoutingModule } from './dashboard.routes';
import { ReactiveFormsModule } from '@angular/forms';
import { MaterialModule } from '../../Modules/material/material.module';
import { NavBarComponent } from '../../Shared/Components/nav-bar/nav-bar.component';
import { TeacherComponent } from './teacher/teacher.component';
import { DepartmentHeadComponent } from './department-head/department-head.component';
import { AdminComponent } from './admin/admin.component';



@NgModule({
  declarations: [
    NavBarComponent,
    TeacherComponent,
    DepartmentHeadComponent,
    AdminComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,
    ReactiveFormsModule,
    MaterialModule
  ]
})
export class DashboardModule { }
