import { Injectable } from '@angular/core';

@Injectable()
export class EntradaService {
  
  url: string = "http://localhost:58492/api/responsavel";
  
  constructor() { }

}
