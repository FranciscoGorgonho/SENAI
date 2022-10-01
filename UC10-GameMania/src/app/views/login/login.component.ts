import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/models/user';
import { LoginService } from 'src/app/services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  //constructor(private loginService: LoginService) { }
  constructor(private loginService: LoginService, private router: Router) { }

  ngOnInit(): void {
  }

  loginModel = new User();

  mensagem = "";

  onSubmit() {
    console.log("Modelo:", this.loginModel)

    const listaPalavras: string[] = ["select ", "from ", "drop ", "or ", "having", "group ", "by ", "insert ", "exec ", "\"", "\'", "--", "#", "*",]

    listaPalavras.forEach(palavra => {
      if(this.loginModel.email.toLowerCase().includes(palavra)) {
        this.mensagem = "Dados inválidos"

        return;
      }
      
    });

    this.loginService.login(this.loginModel).subscribe( (response) => {
      this.mensagem = "Login com sucesso!";
      this.router.navigateByUrl('/');

    }, (erro) => {
      this.mensagem = erro.error;
    } )
  }
}



//   //primeira versão
//   userModel = new User()
//   mensagem = ""

//   receberDados() {
//     console.log(this.userModel)
//     //OAuth 2
//     // Enviar dados para a API
//     this.loginService.login(this.userModel).subscribe( (response) => {
//       console.log("response:", response)
//       console.log("O Status Code é:", response.status)
//       console.log("O token de permissão é:", response.body.accessToken)

//       this.mensagem = "Bem vindo " + response.body.user.nome
//       console.log(this.mensagem)
//     }, (responseErro) => {
//       console.log("responseErro", responseErro)
//       //this.mensagem = "Foi encontrado algum problema, tente novamente" 
//       this.mensagem = responseErro.error
//     })
//   }
// }