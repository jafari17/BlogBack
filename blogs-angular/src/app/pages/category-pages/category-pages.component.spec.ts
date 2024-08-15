import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoryPagesComponent } from './category-pages.component';

describe('CategoryPagesComponent', () => {
  let component: CategoryPagesComponent;
  let fixture: ComponentFixture<CategoryPagesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CategoryPagesComponent]
    });
    fixture = TestBed.createComponent(CategoryPagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
