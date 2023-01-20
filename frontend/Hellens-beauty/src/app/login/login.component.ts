import { Component } from '@angular/core';
import { SharedService } from '../shared.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent {

  constructor(
    private userService: SharedService
) { }


  ngOnInit(): void {
    this.login();
  
  }
  
  
    login(): void{
      var val = {
      
        // email:this.email,
        // password:this.password,
        // usertype: this.usertype
      };
  
      this.userService.createUser(val).subscribe(res =>{
        console.log(val)
      })
    }
  
}
