import { Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { DataComponent } from './data/data.component';
import { EventComponent } from './event/event.component';

export const routes: Routes = [
    { path: '', component: HomeComponent },  
    { path: 'home', component: HomeComponent },
    { path: 'data', component: DataComponent },
    { path: 'event', component: EventComponent }
];
