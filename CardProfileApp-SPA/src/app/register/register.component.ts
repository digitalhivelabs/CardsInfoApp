import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  model: any = {};
  @Output() cancelRegisterEvent = new EventEmitter();

  constructor(private _authService: AuthService) { }

  ngOnInit() {
  }

  register() {

    this._authService.register(this.model).subscribe(() => {
      console.log('Registration successfully');
    }, error => {
      console.log(error);
    });


  }

  cancel() {
    this.cancelRegisterEvent.emit(false);
  }
}
