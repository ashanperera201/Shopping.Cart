import { Component, OnInit } from '../shared/utilities/angular'

@Component({
  templateUrl: './auth.comonent.html',
  styleUrls: ['./auth.comonent.scss']
})

export class AuthComponent implements OnInit {

  toggleFormClass;

  constructor() { }

  ngOnInit() { }

  showSignUp() {
    this.toggleFormClass = 'bounceLeft';
  }

  showLogin() {   
    this.toggleFormClass = 'bounceRight';
  }

}
