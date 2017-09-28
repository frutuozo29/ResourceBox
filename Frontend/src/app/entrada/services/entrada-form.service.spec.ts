import { TestBed, inject } from '@angular/core/testing';

import { EntradaFormService } from './entrada-form.service';

describe('EntradaFormService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [EntradaFormService]
    });
  });

  it('should be created', inject([EntradaFormService], (service: EntradaFormService) => {
    expect(service).toBeTruthy();
  }));
});
