import { Component, Input } from '@angular/core';
import { apiService } from '../../services/apiService';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  @Input('nuvem') nuvem: string;
  @Input('aeroporto') aeroportos: string;
  apiService: apiService;
  data : any
    
  constructor(_apiService : apiService) {
    this.apiService = _apiService;
  }     

  onAnalise() {   
    this.apiService.getCaminho(this.nuvem, this.aeroportos).then(res => this.data = res);   
  }
   
}
