import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoriesCreateComponent } from './categories-create.component';

describe('CategoriesCreateComponent', () => {
  let component: CategoriesCreateComponent;
  let fixture: ComponentFixture<CategoriesCreateComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CategoriesCreateComponent]
    });
    fixture = TestBed.createComponent(CategoriesCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
