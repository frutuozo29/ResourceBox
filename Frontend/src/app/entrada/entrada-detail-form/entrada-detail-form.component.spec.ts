import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EntradaDetailFormComponent } from './entrada-detail-form.component';

describe('EntradaDetailFormComponent', () => {
  let component: EntradaDetailFormComponent;
  let fixture: ComponentFixture<EntradaDetailFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EntradaDetailFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EntradaDetailFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
