import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {

  clientes: any;

  constructor(private http: HttpClient) { }

  ngOnInit() { //Executa Antes do HTM ficar Pronto
    this.getClientes();
  }

  getClientes(){
    this.clientes = this.http.get('http://localhost:5000/values').subscribe(response => 
    {
      this.clientes = response;
      console.log
      }, error => {
        console.log(error);
      });
  }
}
