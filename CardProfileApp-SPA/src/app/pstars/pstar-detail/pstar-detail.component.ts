import { Component, OnInit } from '@angular/core';
import { PsprofileService } from 'src/app/_services/psprofile.service';
import { PSProfile } from 'src/app/_models/psprofile';
import {
  NgxGalleryAnimation,
  NgxGalleryOptions,
  NgxGalleryImage
} from 'ngx-gallery';
import { identifierModuleUrl } from '@angular/compiler';

@Component({
  selector: 'app-pstar-detail',
  templateUrl: './pstar-detail.component.html',
  styleUrls: ['./pstar-detail.component.css']
})
export class PstarDetailComponent implements OnInit {
  profile: PSProfile;
  galleryOptions: NgxGalleryOptions[];
  galleries: any[];

  constructor(private _psService: PsprofileService) {}

  ngOnInit() {
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

    this.loadProfile();
  }

  loadProfile() {
    // TODO: This id must be changed
    const profileId = 1;

    this._psService.getProfile(profileId).subscribe(data => {
      this.profile = data;
      console.log(this.profile);
      this.setImages(this.profile);
    });
  }

  setImages(profile) {
    let imageUrls: any[];
    this.galleries = new Array<any>();

    for (let pIdx = 0; pIdx < profile.photoGalleries.length; pIdx++) {
      imageUrls = new Array<any>();
      for (let idx = 0; idx < profile.photoGalleries[pIdx].previewPhotosUrls.length; idx++) {
        imageUrls.push({
           small: profile.photoGalleries[pIdx].previewPhotosUrls[idx].photoUrl,
           medium: profile.photoGalleries[pIdx].previewPhotosUrls[idx].photoUrl,
           big: profile.photoGalleries[pIdx].previewPhotosUrls[idx].photoUrl,
           description: ''
         });
      }

      let galleryImages: NgxGalleryImage[];
      galleryImages = imageUrls;

      this.galleries[profile.photoGalleries[pIdx].id] = galleryImages;
      // console.log(profile.photoGalleries[pIdx].id);

    }
  }
}
