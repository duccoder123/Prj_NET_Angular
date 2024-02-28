import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-nabar',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './nabar.component.html',
  styleUrl: './nabar.component.css',
})
export class NabarComponent {}
