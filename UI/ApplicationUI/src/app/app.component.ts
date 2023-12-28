import { Component, EventEmitter, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HomeComponent } from "./home/home.component";
import { ImageUploadComponent } from "./ImageUpload/ImageUpload.component";
import { HeaderComponent } from './header/header.component';
import { PaginationComponent } from './pages/pagination/pagination.component';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [CommonModule, RouterOutlet, HomeComponent, ImageUploadComponent, HeaderComponent, PaginationComponent]
})
export class AppComponent {
  title = 'ApplicationUI';

  ReadMsgFromImageUpload(event: any) {
    console.log(event);
  }


}
