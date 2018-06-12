import { PeopleService } from './../Services/people.service';
import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public people: any[];
  searchQuery : string = "";
  public loading: boolean;
  slowSearch : boolean = false;

  constructor(private peopleService: PeopleService) {

  }

  ngOnInit(){
    this.peopleService.getPeople().subscribe(people => {
      this.people = people});
  }

  search(){
    if(this.searchQuery !== undefined){
      this.loading = true;

      if(this.slowSearch){
        this.peopleService.searchSlowly(this.searchQuery).subscribe(people => {
          this.loading = false;
          this.people = people});
      }
      else{
        this.peopleService.search(this.searchQuery).subscribe(people => {
          this.loading = false;
          this.people = people});
      }
    }
  }

  setSlowSearch(){
    this.slowSearch = !this.slowSearch;
  }


}
