import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


import { AppComponent } from './app.component';
import { ConverterComponent } from './converter/converter.component';
import { HttpUtilityService } from './services/http-utility.service';
import { HttpModule, Http } from '@angular/http';

@NgModule({
  declarations: [
    AppComponent,
    ConverterComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    FormsModule
  ],
  providers: [HttpUtilityService],
  bootstrap: [AppComponent]
})
export class AppModule { }
