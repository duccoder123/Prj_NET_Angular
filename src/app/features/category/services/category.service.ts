import { Injectable } from '@angular/core';
import { AddCategoryModel } from '../model/add-category-request.model';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class CategoryService {
  constructor(private http: HttpClient) {}
  addCategory(model: AddCategoryModel): Observable<void> {
    return this.http.post<void>(`https://localhost:7184/api/categories`, model);
  }
}
