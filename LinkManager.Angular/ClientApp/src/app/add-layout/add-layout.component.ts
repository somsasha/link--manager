import { Component, OnInit, Inject, Directive, NgModule } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {TagsInputComponents} from 'bootstrap-tagsinput';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-layout',
  templateUrl: './add-layout.component.html',
  styleUrls: ['./add-layout.component.css']
})

export class AddLayoutComponent implements OnInit {

  httpClient: HttpClient;
  baseUrlc: string;
  router: Router;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, routerc: Router) {
    this.httpClient = http;
    this.baseUrlc = baseUrl;
    this.router = routerc;
  }

  ngOnInit() {
  }

  addLink(order: string, url: string, desc: string, tags: string) {
    const a: ILinkInsert = {
      Description: desc,
      Order: +order,
      Url: url,
      tags: tags
    };
    console.log(a);
    this.httpClient.post(this.baseUrlc + 'api/Links', a).subscribe(result => {
      this.router.navigate(['/']);
    }, error => console.log(error));
  }
}
