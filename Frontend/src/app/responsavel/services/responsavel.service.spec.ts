import { TestBed, inject } from '@angular/core/testing';

import { ResponsavelService } from './responsavel.service';

describe('ResponsavelService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ResponsavelService]
    });
  });

  it('should be created', inject([ResponsavelService], (service: ResponsavelService) => {
    expect(service).toBeTruthy();
  }));
});
