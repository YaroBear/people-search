import { PeopleService } from './../Services/people.service';
import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public people: any[];
  searchQuery: "";

  constructor(private peopleService: PeopleService) {

  }

  ngOnInit(){
    this.peopleService.getPeople().subscribe(people => this.people = people);
  }

  search(){
    if(this.searchQuery !== undefined){
      this.peopleService.search(this.searchQuery).subscribe(people => this.people = people);
    }
  }
}
