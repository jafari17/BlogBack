import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeLabelsComponent } from './home-labels.component';

describe('HomeLabelsComponent', () => {
  let component: HomeLabelsComponent;
  let fixture: ComponentFixture<HomeLabelsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HomeLabelsComponent]
    });
    fixture = TestBed.createComponent(HomeLabelsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
