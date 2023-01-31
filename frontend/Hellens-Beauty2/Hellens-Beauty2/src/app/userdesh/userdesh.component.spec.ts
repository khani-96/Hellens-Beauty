import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserdeshComponent } from './userdesh.component';

describe('UserdeshComponent', () => {
  let component: UserdeshComponent;
  let fixture: ComponentFixture<UserdeshComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserdeshComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserdeshComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
