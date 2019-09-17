import { Injectable, Inject, OnInit } from "@angular/core"
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { Observable } from "rxjs"
import { Consulta } from "../../model/Consulta";

@Injectable({
  providedIn: "root"
})

export class ConsultaServico implements OnInit{

  private _baseUrl: string;
  public consultas: Consulta[]
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;

  }

  ngOnInit(): void {
    this.consultas = []
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json')
  }

  public cadastrar(consulta: Consulta): Observable<Consulta> {

    return this.http.post<Consulta>(this._baseUrl + "api/consulta", JSON.stringify(consulta),{ headers: this.headers })
  }

  public salvar(consulta: Consulta): Observable<Consulta> {

    return this.http.post<Consulta>(this._baseUrl + "api/consulta/salvar", JSON.stringify(consulta), { headers: this.headers })
  }
  public deletar(consulta: Consulta): Observable<Consulta> {

    return this.http.post<Consulta>(this._baseUrl + "api/consulta/deletar", JSON.stringify(consulta), { headers: this.headers })
  }

  public obterTodasConsultas(): Observable<Consulta[]> {

    return this.http.get<Consulta[]>(this._baseUrl + "api/consultas")

  }

  public obterConsulta(consultaId: number): Observable<Consulta> {

    return this.http.get<Consulta>(this._baseUrl + "api/consultas/obterporid")
  }

}
