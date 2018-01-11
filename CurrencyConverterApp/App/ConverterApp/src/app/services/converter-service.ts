import { Injectable } from '@angular/core';
import { HttpUtilityService } from './http-utility.service';


@Injectable()
export class ConverterService{

    constructor(private httpClient: HttpUtilityService){

    }

    convertToWordAndGet(model:any): Promise<any>{
        return this.httpClient.getJsonRequest(model).then(response => {
            return response._body;
        }).catch(error => {
            console.log(error); 
        })
    }
}