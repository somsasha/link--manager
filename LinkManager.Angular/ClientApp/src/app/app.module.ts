import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { LeftSidedMenuComponent } from './left-sided-menu/left-sided-menu.component';
import { LinksLayoutComponent } from './links-layout/links-layout.component';
import { LinksTableComponent } from './links-table/links-table.component';
import { RecentTagsComponent } from './recent-tags/recent-tags.component';
import { ExtendedSearchComponent } from './extended-search/extended-search.component';
import { AddLayoutComponent } from './add-layout/add-layout.component';
import { EditLayoutComponent } from './edit-layout/edit-layout.component';
import { AngularFontAwesomeModule } from 'angular-font-awesome';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LeftSidedMenuComponent,
    LinksLayoutComponent,
    LinksTableComponent,
    RecentTagsComponent,
    ExtendedSearchComponent,
    AddLayoutComponent,
    EditLayoutComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    AngularFontAwesomeModule,
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    RouterModule.forRoot([
      { path: '', component: LinksLayoutComponent, canActivate: [AuthorizeGuard] },
      { path: 'add', component: AddLayoutComponent, pathMatch: 'full', canActivate: [AuthorizeGuard] },
      { path: 'edit/:id', component: EditLayoutComponent, pathMatch: 'full', canActivate: [AuthorizeGuard] }
    ])
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
