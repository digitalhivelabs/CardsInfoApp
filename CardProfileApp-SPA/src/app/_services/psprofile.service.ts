import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';
import { PSProfile } from '../_models/psprofile';

@Injectable({
  providedIn: 'root'
})
export class PsprofileService {

  baseUrl = environment.apiUrl;

  constructor(private _http: HttpClient) { }

  getProfile(id): Observable<PSProfile> {

    return this._http.get<PSProfile>(this.baseUrl + 'psprofiles/' + id);

  }

}
