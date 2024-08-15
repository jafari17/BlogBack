import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LabelPagesComponent } from './label-pages.component';

describe('LabelPagesComponent', () => {
  let component: LabelPagesComponent;
  let fixture: ComponentFixture<LabelPagesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [LabelPagesComponent]
    });
    fixture = TestBed.createComponent(LabelPagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
