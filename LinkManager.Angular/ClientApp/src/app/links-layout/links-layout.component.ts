import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-links-layout',
  templateUrl: './links-layout.component.html',
  styleUrls: ['./links-layout.component.css']
})
export class LinksLayoutComponent implements OnInit {
  models: ILinkIndexViewModel[];
  http: HttpClient;
  baseUrl: string;
  route: ActivatedRoute;
  tagId: string = '';
  extSearch: string = '';

  constructor(httpc: HttpClient, @Inject('BASE_URL') baseUrlc: string, routec: ActivatedRoute) {
    this.http = httpc;
    this.baseUrl = baseUrlc;
    this.route = routec;
  }

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      console.warn(params);
      this.tagId = params['tagId'];
      this.extSearch = params['extSearch'];
      let paramsc = new HttpParams();
    paramsc.set('tagId', this.tagId);
    paramsc.set('extSearch', this.extSearch);
    console.log(paramsc);
    let finalUrl = '';
    if (this.tagId) { finalUrl += `tagId=${this.tagId}&`; }
    if (this.extSearch) { finalUrl += `extSearch=${this.extSearch}&`; }
    this.http.get<ILinkIndexViewModel[]>(this.baseUrl + `api/Links?${finalUrl}`, { params: paramsc }).subscribe(result => {
      this.models = result;
      console.log(this.models);
    }, error => console.error(error));
    });
  }

}
