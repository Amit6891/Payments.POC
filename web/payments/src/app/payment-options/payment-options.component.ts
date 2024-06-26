import { Component, OnInit } from '@angular/core';
import { Account } from './models/account';
import { PaymentService } from './services/payment.service';

@Component({
  selector: 'app-payment-options',
  templateUrl: './payment-options.component.html',
  styleUrls: ['./payment-options.component.scss']
})
export class PaymentOptionsComponent implements OnInit {
  
  public account: Account | undefined;
  
  constructor(private readonly paymentInfoService: PaymentService) { }
  
  ngOnInit(): void {
    this.paymentInfoService
      .getPaymentInfo()
      .subscribe((res) => {
        this.account = res;
      })
  }

  payNow(): void {
    alert("Success!!!");
  }
}
