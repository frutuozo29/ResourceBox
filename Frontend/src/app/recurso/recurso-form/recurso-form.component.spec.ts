import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecursoFormComponent } from './recurso-form.component';

describe('RecursoFormComponent', () => {
  let component: RecursoFormComponent;
  let fixture: ComponentFixture<RecursoFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecursoFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecursoFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
