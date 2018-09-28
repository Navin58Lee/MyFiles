import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MobilecomponentComponent } from './mobilecomponent.component';

describe('MobilecomponentComponent', () => {
  let component: MobilecomponentComponent;
  let fixture: ComponentFixture<MobilecomponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MobilecomponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MobilecomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
