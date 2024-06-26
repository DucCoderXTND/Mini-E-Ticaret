import { Component, OnInit } from '@angular/core';
import { AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit{
  constructor(private alertify: AlertifyService){}
  ngOnInit(): void {
   this.message();
  }

  message(){
    this.alertify.message("Tran Hoang Duc", {
      messageType: MessageType.Success,
      delay: 5,
      position: Position.BottomRight,

    } )
  }

  d(){
    this.alertify.dismiss();
  }

}
