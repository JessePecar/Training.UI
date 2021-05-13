<template>
<div>
    <h2 class="w-100 text-center bg-purple text-white p-2 rounded shadow">My Friends</h2>
    <add-friend @submit-friend="addFriend"></add-friend>
    <ul class="list-group list-group-flush">
      <li class="list-group-item" v-for="friend in friends" :key="friend.id">
        <friend-contact @delete-friend="removeFriend" :id="friend.id" :name="friend.name" :phone-number="friend.phone" :email-address="friend.email" :is-favorite="friend.favorite" @toggle-favorite="toggleFavorite"></friend-contact>
      </li>
    </ul>
</div>
</template>

<script>
export default {
  data() {
    return {
      friends: [
        {
          id: 1,
          name: "Jose Cuervo",
          phone: "123 456 7890",
          email: "Jose@tequila.com",
          favorite: true
        },
        {
          id: 2,
          name: "Johnnie Walker",
          phone: "123 456 7891",
          email: "Johnnie@whiskey.com",
          favorite: false
        },
        {
          id: 3,
          name: "Bombay Sapphire",
          phone: "123 456 7892",
          email: "Bombay@gin.com",
          favorite: false
        }
      ]
    };
  },
  methods: {
    toggleFavorite(friendId) {
      const matchedFriend = this.friends.find(friend => friend.id === friendId);
      matchedFriend.favorite = !matchedFriend.favorite;
    },
    addFriend(friend) {
      const newFriendId = Math.floor(Math.random() * 1000000);
      friend.id = newFriendId;
      this.friends.push(friend);
    },
    removeFriend(friend) {
      this.friends = this.friends.filter(f => f.id !== friend);
    }
  },
  components: {}
};
</script>

