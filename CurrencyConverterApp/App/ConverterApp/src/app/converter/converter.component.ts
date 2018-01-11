import { ConverterService } from './../services/converter-service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-converter',
  templateUrl: './converter.component.html',
  styleUrls: ['./converter.component.css'],
  providers: [ConverterService]
})
export class ConverterComponent implements OnInit {

  isOutputFound:false;
  model:any = {name: '', currency: ''};
  outputModel:any = {};

  constructor(private service: ConverterService) { }

  ngOnInit() {
  }

  convert(){
    this.isOutputFound = false;
    this.service.convertToWordAndGet(this.model).then(response =>{
      const data = JSON.parse(response);
      this.outputModel = data;
      this.outputModel.raw = response;
      this.isOutputFound = true;
    }).catch(error=>{

    });
  }

}
