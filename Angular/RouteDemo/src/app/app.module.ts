import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule,routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { MindsComponent } from './minds/minds.component';
import { TrackComponent } from './track/track.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { TracklistComponent } from './tracklist/tracklist.component';

@NgModule({
  declarations: [
    AppComponent,
    MindsComponent,
    TrackComponent,
    routingComponents,
    PageNotFoundComponent,
    TracklistComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
