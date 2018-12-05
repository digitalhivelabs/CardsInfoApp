/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PstarEditComponent } from './pstar-edit.component';

describe('PstarEditComponent', () => {
  let component: PstarEditComponent;
  let fixture: ComponentFixture<PstarEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PstarEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PstarEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
