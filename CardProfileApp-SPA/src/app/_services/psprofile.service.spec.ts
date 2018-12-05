/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PsprofileService } from './psprofile.service';

describe('Service: Psprofile', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PsprofileService]
    });
  });

  it('should ...', inject([PsprofileService], (service: PsprofileService) => {
    expect(service).toBeTruthy();
  }));
});
