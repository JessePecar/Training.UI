import {
    createApp
} from 'vue'
import App from './App.vue';
import FriendContact from './components/FriendContact.vue';
import AddFriend from './components/AddFriend.vue';
import Friend from './components/Friend.vue';
import User from './components/User.vue';
import UserData from './components/UserData.vue';
import ActiveUser from './components/ActiveUser.vue';

// Import Bootstrap an BootstrapVue CSS files (order is important)
import '../public/css/bootstrap-custom-theme.css'
import '../public/css/site.css'

const app = createApp(App);

app.component('friend-contact', FriendContact);
app.component('add-friend', AddFriend);
app.component('friend', Friend);
app.component('user', User);
app.component('user-data', UserData);
app.component('active-user', ActiveUser);
app.mount('#app');