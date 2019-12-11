import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-left-sided-menu',
  templateUrl: './left-sided-menu.component.html',
  styleUrls: ['./left-sided-menu.component.css']
})
export class LeftSidedMenuComponent implements OnInit {

  @Input()
  tags: ITag[];

  constructor() { }

  ngOnInit() {
  }

}
