import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map, retry } from 'rxjs/operators';

@Injectable()
export class apiService {

  connection: string = "https://localhost:44394/api/Clouds"; 
  
  constructor(private http: HttpClient) { }
      
       getCaminho(nuvem: any, caminho: any) {
         const headers = { 'content-type': 'application/json' }
         return this.http.post(this.connection, JSON.stringify({ 'nuvem': nuvem, 'aeroporto': caminho }), { 'headers': headers })
           .pipe(retry(1), map(data => data)).toPromise();
            
       }
  
 

 }
