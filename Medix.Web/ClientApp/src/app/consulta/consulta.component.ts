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
  public mensagem: string;
  public consultas: Consulta[];
constructor(private consultaServico: ConsultaServico)
{

}


  ngOnInit(): void {
    this.consulta = new Consulta();
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
          this.mensagem = e.error          
        }
      );
  }
  public mostrar() {
    this.consultaServico.obterTodasConsultas()
      .subscribe(result => {
        this.consultas = result;
        console.log(result);
      },
        e => {
          console.log(e.error)
        }
      );
  }

}
