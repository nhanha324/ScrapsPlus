namespace ScrapsPlus.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }


    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

    export class ProfileController {
        public message = "Profile controller";
        public profile;
        constructor(private accountService: ScrapsPlus.Services.AccountService, private $http: ng.IHttpService, private $q: ng.IQService) {
            this.getProfile(accountService.getUserEmail());
        }

        getProfile(email) {
            this.$http.get('/api/account/profile', { params: { email: email } }).then((result) => {
                this.profile = result.data;
                console.log(this.profile);
            }).catch((result) => {
                var messages = result.data;
                console.log(messages);
            });
        }
    }

}
