import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ModelResponse } from "../Models/ModelResponse";

@Injectable({
  providedIn: 'root'
})
export class ApiclientService {

  url: string = "https://localhost:7043/api/client";
  constructor( 
    private _http: HttpClient 
    ) { }
    getClientService(): Observable<ModelResponse> {

      return this._http.get<ModelResponse>(this.url);
  }
}
