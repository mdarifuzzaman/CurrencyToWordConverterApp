import { ConverterService } from './../services/converter-service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-converter',
  templateUrl: './converter.component.html',
  styleUrls: ['./converter.component.css'],
  providers: [ConverterService]
})
export class ConverterComponent implements OnInit {

  isOutputFound:boolean = false;
  outputModel:any = {};

  form;

  constructor(private service: ConverterService) { }

  ngOnInit() {
    this.form = new FormGroup({
      name: new FormControl("", Validators.required),
      currency: new FormControl("", Validators.compose([Validators.required, Validators.pattern('^[1-9]\\d*(\\.\\d+)?$')]))
    });
  }

  convert(){
    this.isOutputFound = false;
    this.service.convertToWordAndGet({name: this.form.controls.name.value, currency: this.form.controls.currency.value}).then(response =>{
      const data = JSON.parse(response);
      this.outputModel = data;
      this.outputModel.raw = response;
      this.isOutputFound = true;
    }).catch(error=>{

    });
  }

}
