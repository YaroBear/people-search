import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public people: People[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<People[]>(baseUrl + 'api/people').subscribe(result => {
      this.people = result;
    }, error => console.error(error));
  }
}



interface People {
  id: number,
  name: string;
  address: string
  age: number;
  interests: string;
  picture: string;
}
