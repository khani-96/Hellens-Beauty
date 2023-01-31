import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
@Injectable(
    { providedIn: 'root'})
export class SharedService {

  readonly APIUrl = "http://localhost:63167/api";
  constructor(private http: HttpClient) {}

  createUser(val: any) {
      return this.http.post(this.APIUrl + '/user', val);
  }

  // getUser(): Observable < any[] > {
  //     return this.http.get < any > (this.APIUrl + '/user');
  // }

  updateUser(id: any) {
      return this.http.put(this.APIUrl + '/user', id);
  }
  deleteUser(id: any) {
      return this.http.delete(this.APIUrl + '/user/' + id);
  }

}

