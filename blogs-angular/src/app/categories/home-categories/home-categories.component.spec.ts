import { ComponentFixture, TestBed } from '@angular/core/testing';
import { homeCategoriesComponent } from './home-categories.component';

 
describe('HomeComponent', () => {
  let component: homeCategoriesComponent;
  let fixture: ComponentFixture<homeCategoriesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [homeCategoriesComponent]
    });
    fixture = TestBed.createComponent(homeCategoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
