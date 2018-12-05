import { Component, OnInit, ViewChild } from '@angular/core';
import { User } from '../../_models/user';
import { AlertifyService } from '../../_services/alertify.service';
import { ActivatedRoute } from '@angular/router';
import { UserService } from '../../_services/user.service';
import { NgxGalleryOptions, NgxGalleryImage, NgxGalleryAnimation } from 'ngx-gallery';
import { TabsetComponent } from 'ngx-bootstrap';

@Component({
  selector: 'app-member-detail',
  templateUrl: './member-detail.component.html',
  styleUrls: ['./member-detail.component.css']
})
export class MemberDetailComponent implements OnInit {

  @ViewChild('memberTabs') memberTabs: TabsetComponent;
  user: User;
  galleryOptions: NgxGalleryOptions[];
  galleryImages: NgxGalleryImage[];

  constructor(private _userService: UserService, private _alertify: AlertifyService, private _route: ActivatedRoute) { }

  ngOnInit() {
    this._route.data.subscribe(data => {
      this.user = data['user'];
    });

    this._route.queryParams.subscribe(params => {
      const selectTab = params['tab'];
      this.memberTabs.tabs[selectTab > 0 ? selectTab : 0].active = true;
    });

    this.galleryOptions = [
      {
        width: '500px',
        height: '500px',
        imagePercent: 100,
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide,
        preview: false
      }
    ];

    this.galleryImages = this.getImages();
  }

  getImages() {

    const imageUrls = [];

    for (let idx = 0; idx < this.user.photos.length; idx++) {
      imageUrls.push({
        small: this.user.photos[idx].url,
        medium: this.user.photos[idx].url,
        big: this.user.photos[idx].url,
        description: this.user.photos[idx].description
      });
    }

    return imageUrls;

  }

  selectTab(tabId: number) {
    this.memberTabs.tabs[tabId].active = true;
  }

}
