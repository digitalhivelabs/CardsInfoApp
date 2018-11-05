import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model: any = {};

  constructor(public _autService: AuthService, private _alertify: AlertifyService) { }

  ngOnInit() {
  }

  login() {
    this._autService.login(this.model).subscribe(next => {
      this._alertify.success('Logged inf successfully');
    }, error => {
      this._alertify.error(error);
    });

  }

  loggedIn() {
    return this._autService.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    this._alertify.message('Logged out');
  }

}
