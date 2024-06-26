import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Account } from "../models/account";

@Injectable({
    providedIn: 'root'
})
export class PaymentService {
    
    constructor(private readonly http: HttpClient){}

    getPaymentInfo(): Observable<Account> {
        return this.http.get<Account>("https://localhost:44330/api/Accounts");
    }
}