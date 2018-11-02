import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model: any = {};

  constructor(private _autService: AuthService) { }

  ngOnInit() {
  }

  login() {
    this._autService.login(this.model).subscribe(next => {
      console.log('Login Successfully');
    }, error => {
      console.log(error);
    });

  }

}
