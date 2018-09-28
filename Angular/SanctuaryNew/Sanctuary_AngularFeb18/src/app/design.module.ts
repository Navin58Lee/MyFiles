import{NgModule} from '@angular/core';
import{CommonModule} from '@angular/common';
import {MatButtonModule} from '@angular/material/button';
import {MatDialogModule} from '@angular/material/dialog';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatListModule} from '@angular/material/list';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import {MatCardModule} from '@angular/material/card';
import {MatTooltipModule} from '@angular/material/tooltip';
import { MatTableModule } from '@angular/material/table'

@NgModule(
    {
        imports:[MatButtonModule,MatDialogModule,MatFormFieldModule,MatInputModule,MatSelectModule,MatGridListModule,
                 MatListModule, MatDatepickerModule,MatNativeDateModule, MatCardModule, MatTooltipModule, MatTableModule],
        exports:[MatButtonModule,MatDialogModule,MatFormFieldModule,MatInputModule,MatSelectModule,MatGridListModule,
                 MatListModule, MatDatepickerModule, MatNativeDateModule , MatCardModule, MatTooltipModule, MatTableModule]
        
    }
)

export class MaterialModule{}