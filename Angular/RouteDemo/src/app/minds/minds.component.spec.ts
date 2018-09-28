import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MindsComponent } from './minds.component';

describe('MindsComponent', () => {
  let component: MindsComponent;
  let fixture: ComponentFixture<MindsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MindsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MindsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
