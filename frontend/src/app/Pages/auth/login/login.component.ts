import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {

  private loginFormBuilder: FormBuilder = new FormBuilder();
  loginForm: FormGroup = this.loginFormBuilder.group({
    cnic: ['', [Validators.required, Validators.minLength(6), Validators.maxLength(20)]],
    password: ['', [Validators.required, Validators.minLength(6), Validators.maxLength(50)]]
  })

  handleLogin(){
    if(this.loginForm.valid){
      console.log(this.loginForm.value);
    }
  }
}
