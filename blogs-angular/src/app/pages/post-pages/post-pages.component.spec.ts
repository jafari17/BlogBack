import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PostPagesComponent } from './post-pages.component';

describe('PostPagesComponent', () => {
  let component: PostPagesComponent;
  let fixture: ComponentFixture<PostPagesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PostPagesComponent]
    });
    fixture = TestBed.createComponent(PostPagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
