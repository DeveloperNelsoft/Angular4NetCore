import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Car } from '../models/index';
import { Observable } from 'rxjs/Observable';
import "rxjs/Rx";

@Injectable()
export class CarService {

    private _getContactsUrl = "/Car/GetCar";

    constructor(private http: Http) { }

    getCars() {
        var headers = new Headers();
        var getContactsUrl = this._getContactsUrl;
        return this.http.get(getContactsUrl, { headers: headers })
            .map(response => <any>(<Response>response).json());
    }

   
    private handleError(error: Response) {
        return Observable.throw(error.json().error || 'Opps!! Server error');
    }

}