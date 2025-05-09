import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { ApiService } from './service/api.service';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,FormsModule, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'ejercicio-Analytics360';

  input: string = '';

  constructor (private service: ApiService){}

  onClick(){
    if(this.input != ''){
      if(this.validaBalanceo()){
        alert('Estan balanceados');
        this.guardarValidacion(this.input, 1);
      }else{
        alert('No estan balanceados');
        this.guardarValidacion(this.input, 0);
      }
    }else{
      alert('Ingresa un valor');
    }
  }

  validaBalanceo(){
    const pila: string[] = [];
    const mapaParejas: Record<string, string> = {
      ')': '(',
      '}': '{',
      ']': '['
    };

    for(let char of this.input){
      if(char == '(' || char == '[' || char == '{'){
        pila.push(char);
      }else{
        if(pila.length == 0){
          return false;
        }else{
          const ultimoItem = pila.pop();
          if(ultimoItem != mapaParejas[char]){
            return false;
          }
        }
      }
    }
    return pila.length == 0;
  }

  guardarValidacion(input:string, result:number){
    const data={
      input: input,
      result: result
    }
    this.service.save(data).subscribe(()=>{
        });
  }

  filtrarCaracteres(event: any) {
  const valor = event.target.value;
  event.target.value = valor.replace(/[^()\[\]{}]/g, '');
}
}

