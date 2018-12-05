import { Component, OnInit, Input } from '@angular/core';
import { Message } from '../../_models/message';
import { AuthService } from '../../_services/auth.service';
import { AlertifyService } from '../../_services/alertify.service';
import { UserService } from 'src/app/_services/user.service';
import { tap } from 'rxjs/operators';

@Component({
  selector: 'app-member-messages',
  templateUrl: './member-messages.component.html',
  styleUrls: ['./member-messages.component.css']
})
export class MemberMessagesComponent implements OnInit {

  @Input() recipientId: number;
  messages: Message[];
  newMessage: any = {};

  constructor(private _userService: UserService, private _authService: AuthService, private _alertify: AlertifyService) { }

  ngOnInit() {
    this.loadMessages();
  }

  loadMessages() {
    const currentUserId = +this._authService.decodedToken.nameid;
    this._userService.getMessageThread(this._authService.decodedToken.nameid, this.recipientId)
      .pipe(
        tap(messages => {
          for (let idx = 0; idx < messages.length; idx++ ) {
            if (messages[idx].isRead === false && messages[idx].recipientId === currentUserId) {
              this._userService.markAsRead(currentUserId, messages[idx].id);
            }
          }
        })
      )
      .subscribe(messages => {
        this.messages = messages;
      }, error => {
        this._alertify.error(error);
      });
  }

  sendMessage() {
    this.newMessage.recipientId = this.recipientId;
    this._userService.sendMessage(this._authService.decodedToken.nameid, this.newMessage).subscribe((message: Message) => {
      this.messages.unshift(message);
      this.newMessage.content = '';
    }, error => {
      this._alertify.error(error);
    });
  }

}
