import { Component, OnInit, Inject, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { error } from 'util';

@Component({
  selector: 'app-links-table',
  templateUrl: './links-table.component.html',
  styleUrls: ['./links-table.component.css']
})
export class LinksTableComponent implements OnInit {

  @Input()
  public links: ILink[];
  http: HttpClient;
  baseUrl: string;

  constructor(httpc: HttpClient, @Inject('BASE_URL') baseUrlc: string) {
    this.http = httpc;
    this.baseUrl = baseUrlc;
   }
  ngOnInit() {
  }

  deleteLink(id: string) {
    const linkIndex = this.links.findIndex(link => link.Id === +id);
    this.http.delete(this.baseUrl + `api/Links/${id}`).subscribe(result => {
      this.links.splice(linkIndex, 1);
    }, error => console.warn(error));
  }
}
