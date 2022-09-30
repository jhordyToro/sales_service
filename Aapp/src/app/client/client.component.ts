import { Component, OnInit } from '@angular/core';
import { ApiclientService } from '../service/apiclient.service';

@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.scss']
})
export class ClientComponent implements OnInit {

  constructor(
    private apiClient: ApiclientService
  ) 
  { 
    apiClient.getClient().subscribe( response => { console.log(response) } )
  }
  

  ngOnInit(): void {
  }

}
