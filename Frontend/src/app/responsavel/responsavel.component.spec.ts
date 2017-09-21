import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResponsavelComponent } from './responsavel.component';

describe('ResponsavelComponent', () => {
  let component: ResponsavelComponent;
  let fixture: ComponentFixture<ResponsavelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResponsavelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResponsavelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
