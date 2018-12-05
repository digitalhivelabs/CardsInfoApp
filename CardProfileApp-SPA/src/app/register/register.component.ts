import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { BsDatepickerConfig } from 'ngx-bootstrap';
import { User } from '../_models/user';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  user: User;
  @Output() cancelRegisterEvent = new EventEmitter();
  registerForm: FormGroup;
  bsConfig: Partial<BsDatepickerConfig>;

  constructor(private _authService: AuthService, private _router: Router, private _alertify: AlertifyService, private _fb: FormBuilder) { }

  ngOnInit() {
    // this.registerForm = new FormGroup({
    //   username: new FormControl('', Validators.required),
    //   displayname: new FormControl('', Validators.required),
    //   password: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(8)]),
    //   confirmPassword: new FormControl('', Validators.required)
    // }, this.passwordMatchValidator);
    this.bsConfig = {
      containerClass: 'theme-red'
    };
    this.createRegisterForm();
  }

  createRegisterForm() {
    this.registerForm = this._fb.group({
      gender: ['female'],
      username: ['', Validators.required],
      displayname: ['', Validators.required],
      knownAs: ['', Validators.required],
      dateOfBirth: [null, Validators.required],
      city: ['', Validators.required],
      country: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(8)]],
      confirmPassword: ['', Validators.required]
    }, { validator: this.passwordMatchValidator });
  }

  passwordMatchValidator(g: FormGroup) {
    return g.get('password').value === g.get('confirmPassword').value ? null : { 'mismatch': true };
  }

  register() {

    if (this.registerForm.valid) {
      this.user = Object.assign({}, this.registerForm.value);
      this._authService.register(this.user).subscribe(() => {
        this._alertify.success('Registration Successful');
      }, error => {
        this._alertify.error(error);
      }, () => {
        this._authService.login(this.user).subscribe(() => {
          this._router.navigate(['/members']);
        });
      });
    }
  }

  cancel() {
    this.cancelRegisterEvent.emit(false);
  }
}
