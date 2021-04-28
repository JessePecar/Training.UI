import {
    createApp
} from 'vue'
import App from './App.vue';
import FriendContact from './components/FriendContact.vue';

// Import Bootstrap an BootstrapVue CSS files (order is important)
import '../public/css/bootstrap-custom-theme.css'
import '../public/css/site.css'

const app = createApp(App);

app.component('friend-contact', FriendContact);

app.mount('#app');