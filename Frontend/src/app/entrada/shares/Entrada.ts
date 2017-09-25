import { RecursoEntrada } from './RecursoEntrada';

export class Entrada {
    Id: number;
    Data: Date;
    ResponsavelId: number;
    ResponsavelNome: string;
    RecursosEntrada: RecursoEntrada[];
}