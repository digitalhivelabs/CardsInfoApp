import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  model: any = {};
  @Output() cancelRegisterEvent = new EventEmitter();

  constructor(private _authService: AuthService, private _alertify: AlertifyService) { }

  ngOnInit() {
  }

  register() {

    this._authService.register(this.model).subscribe(() => {
      this._alertify.success('Registration successfully');
    }, error => {
      this._alertify.error(error);
    });


  }

  cancel() {
    this.cancelRegisterEvent.emit(false);
  }
}
