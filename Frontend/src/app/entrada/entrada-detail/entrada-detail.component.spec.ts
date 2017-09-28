import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EntradaDetailComponent } from './entrada-detail.component';

describe('EntradaDetailComponent', () => {
  let component: EntradaDetailComponent;
  let fixture: ComponentFixture<EntradaDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EntradaDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EntradaDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
