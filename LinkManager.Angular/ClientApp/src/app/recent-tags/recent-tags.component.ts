import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-recent-tags',
  templateUrl: './recent-tags.component.html',
  styleUrls: ['./recent-tags.component.css']
})
export class RecentTagsComponent implements OnInit {

  @Input()
  public recentTags: ITag[];
  constructor() { }

  ngOnInit() {
    console.warn(this.recentTags);
  }

}
