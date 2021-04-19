import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title:string = 'The Dating App';
  users: any;
  
  constructor(private http: HttpClient){}
    //XRf Construccion de Htt}

    ngOnInit(){
      this.getUser();
      //El subscribe, basicamente nos subscribe para que nos llegue la informacion
      //Este nos devuelve una respesta exitosa o un error    
    }

  getUser(){
    this.http.get('https://localhost:5001/api/users').subscribe(response =>{
      this.users = response;
    }, error => {
      console.log(error);
    }); 
  }
}

// El operador => reemplaza la palabra function en
// Desde aqui pasamos informacion al html