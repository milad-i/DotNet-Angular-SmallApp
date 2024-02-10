import { Component, OnInit } from '@angular/core';
import { BookService } from '../services/book.service';
import { BookInterface } from '../models/book.model';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-data',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './data.component.html',
  styleUrl: './data.component.scss'
})
export class DataComponent implements OnInit {

  books?: BookInterface[];
  isSuccess = false;

  constructor(private bookService: BookService){}

  ngOnInit(): void {
     this.bookService.getData().subscribe(data => {
      this.books = data;
      this.isSuccess = true;
    });
  }
}
