import { TestBed, inject } from '@angular/core/testing';

import { EntradaService } from './entrada.service';

describe('EntradaService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [EntradaService]
    });
  });

  it('should be created', inject([EntradaService], (service: EntradaService) => {
    expect(service).toBeTruthy();
  }));
});
