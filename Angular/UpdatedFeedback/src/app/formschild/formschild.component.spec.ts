import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormschildComponent } from './formschild.component';

describe('FormschildComponent', () => {
  let component: FormschildComponent;
  let fixture: ComponentFixture<FormschildComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormschildComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormschildComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
