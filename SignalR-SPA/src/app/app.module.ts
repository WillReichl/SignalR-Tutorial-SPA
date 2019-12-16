import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';

import { ToastModule } from 'primeng/toast';

import { AppComponent } from './app.component';
import { MessageService } from 'primeng/components/common/messageservice';

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, BrowserAnimationsModule, ToastModule],
  providers: [MessageService],
  bootstrap: [AppComponent]
})
export class AppModule {}
