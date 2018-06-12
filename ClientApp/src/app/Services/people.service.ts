import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import 'rxjs';

@Injectable()
export class PeopleService {

  constructor(private http: HttpClient) { }

  getPeople(){
    return this.http.get<People[]>('/api/people')
  }

  search(searchString: string){
    return this.http.get<People[]>('/api/people/search/' +  searchString)
  }

  searchSlowly(searchString: string){
    return this.http.get<People[]>('/api/people/slowSearch/' +  searchString)
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

