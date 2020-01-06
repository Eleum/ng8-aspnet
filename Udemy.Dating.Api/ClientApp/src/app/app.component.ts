import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';

declare var FB: any;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'udemy-dating';

  ngOnInit() {
    (window as any).fbAsyncInit = () => {
      FB.init({
        appId: '',
        cookie: true,
        xfbml: true,
        version: 'v5.0'
      });
      FB.AppEvents.logPageView();
    };

    (function(d, s, id) {
      const fjs = d.getElementsByTagName(s)[0];

      if (d.getElementById(id)) {
        return;
      }

      let js: any;
      js = d.createElement(s);
      js.id = id;
      js.src = 'https://connect.facebook.net/en_US/sdk.js';

      fjs.parentNode.insertBefore(js, fjs);
    }(document, 'script', 'facebook-jssdk'));
  }

  facebookLogin() {
    console.log('submitting login to facebook');

    FB.login((response) => {
      console.log('facebook login response', response);
      if (response.authResponse) {
        FB.api('/me', {
          fields: 'last_name, first_name, email, picture'
        }, (userInfo) => {
          $('#fbResponseInfo').html('<code>' + JSON.stringify(response, null, 2) + '</code>');
          $('#fbUserInfo').html('<code>' + JSON.stringify(userInfo, null, 2) + '</code>');
        });
      } else {
        console.error('login failed');
      }
    }, {scope: 'public_profile, email'});
  }
}
