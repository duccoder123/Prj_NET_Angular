import { Component, OnDestroy } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AddCategoryModel } from '../model/add-category-request.model';
import { CategoryService } from '../services/category.service';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-add-category',
  standalone: true,
  imports: [FormsModule, HttpClientModule],
  templateUrl: './add-category.component.html',
  styleUrl: './add-category.component.css',
})
export class AddCategoryComponent implements OnDestroy {
  model: AddCategoryModel;
  private addCategorySubscribtion?: Subscription;
  constructor(private categoryService: CategoryService) {
    this.model = {
      name: '',
      handleUrl: '',
    };
  }

  onFormSubmit() {
    this.addCategorySubscribtion = this.categoryService
      .addCategory(this.model)
      .subscribe({
        next: (response) => {
          console.log('This was successful');
        },
      });
  }

  ngOnDestroy(): void {
    this.addCategorySubscribtion?.unsubscribe();
  }
}
