import { Component } from "@angular/core"

@Component({
  selector: "app-consulta",
  template: "<html><body>{{ obterDataInicioConsulta() }}</body></html>"
})
export class ConsultaComponent {

  public DataInicioConsulta: Date;
  public DataFimConsulta: Date;
  public NomePaciente: string;
  public DataNascimentoPaciente: Date;

  public obterDataInicioConsulta(): Date {
    return new Date();
  }

}
