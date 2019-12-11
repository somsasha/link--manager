import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-edit-layout',
  templateUrl: './edit-layout.component.html',
  styleUrls: ['./edit-layout.component.css']
})
export class EditLayoutComponent implements OnInit {

  public link: ILink;
  httpClient: HttpClient;
  baseUrlc: string;
  router: Router;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, routerc: Router) {
    this.httpClient = http;
    this.baseUrlc = baseUrl;
    this.router = routerc;
  }
  ngOnInit() {
    this.link = history.state.data as ILink;
  }

  updateComponent() {
    this.httpClient.put(this.baseUrlc + 'api/Links/' + this.link.Id, this.link).subscribe(result => {
      this.router.navigate(['/']);
    }, error => console.log(error));
  }

}
