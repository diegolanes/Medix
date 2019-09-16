import { Component, OnInit } from "@angular/core"
import { Consulta } from "../model/Consulta"
import { ConsultaServico } from "../servicos/consulta/consulta.servico";

@Component({
  selector: "app-consulta",
  templateUrl: "./consulta.component.html",
  styleUrls : ["./consulta.component.css"]
})
export class ConsultaComponent implements OnInit {

  public consulta: Consulta
constructor(private consultaServico: ConsultaServico)
{

}




  ngOnInit(): void {
    throw new Error("Method not implemented.");
  }

  public cadastrar() {

    //this.consulta
    this.consultaServico.cadastrar(this.consulta)
      .subscribe(
        consultaJson => {
          console.log(consultaJson)
        },
        e => {
          console.log(e.error)
        }
      );
  }
}
