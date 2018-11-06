import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model: any = {};

  constructor(public _autService: AuthService, private _alertify: AlertifyService, private _router: Router) { }

  ngOnInit() {
  }

  login() {
    this._autService.login(this.model).subscribe(next => {
      this._alertify.success('Logged inf successfully');
    }, error => {
      this._alertify.error(error);
    }, () => {
      this._router.navigate(['/members']);
    });

  }

  loggedIn() {
    return this._autService.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    this._alertify.message('Logged out');
    this._router.navigate(['/home']);
  }

}
