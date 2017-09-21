import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResponsavelFormComponent } from './responsavel-form.component';

describe('ResponsavelFormComponent', () => {
  let component: ResponsavelFormComponent;
  let fixture: ComponentFixture<ResponsavelFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResponsavelFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResponsavelFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
