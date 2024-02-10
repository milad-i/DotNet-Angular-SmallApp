import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BookInterface } from '../models/book.model';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private apiUrl: string = "https://localhost:7243/data";

  constructor(private http: HttpClient) {}

  getData(): Observable<BookInterface[]> { 
    return this.http.get<BookInterface[]>(this.apiUrl);
  }
}
