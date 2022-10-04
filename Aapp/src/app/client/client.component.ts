import { Component, OnInit } from '@angular/core';
import { ApiclientService } from '../service/apiclient.service';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.scss']
})
export class ClientComponent implements OnInit {
  
  public lst: any[] = [];

  constructor(
    private apiClient: ApiclientService
  ) 
  { }
  

  ngOnInit(): void {
    this.getClient();
  }

  getClient() {
    this.apiClient.getClientService().subscribe( response => { this.lst = response.data; } );
  }

}
