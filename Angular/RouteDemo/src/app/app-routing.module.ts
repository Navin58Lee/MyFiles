import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MindsComponent } from './minds/minds.component';
import { TrackComponent } from './track/track.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
const routes: Routes = [
  {path : '', redirectTo:'/minds',pathMatch:'full'},
  {path : 'minds', component : MindsComponent},
  {path : 'track', component :  TrackComponent},
  {path : "**", component : PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [MindsComponent,TrackComponent,PageNotFoundComponent]
