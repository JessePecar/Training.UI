<template>
<div>
    <h2 class="w-100 text-center bg-purple text-white p-2 rounded shadow">My Friends</h2>
    <ul class="list-group list-group-flush">
      <li class="list-group-item" v-for="friend in friends" :key="friend.id"><friend-contact :name="friend.name" :phone-number="friend.phone" :email-address="friend.email" :is-favorite="friend.favorite"></friend-contact></li>
    </ul>
</div>
</template>

<script>
export default {
  data() {
    return {
      friends: [
        {
          id: "1",
          name: "Jose Cuervo",
          phone: "123 456 7890",
          email: "Jose@tequila.com",
          favorite: true
        },
        {
          id: "2",
          name: "Johnnie Walker",
          phone: "123 456 7891",
          email: "Johnnie@whiskey.com"
        },
        {
          id: "3",
          name: "Bombay Sapphire",
          phone: "123 456 7892",
          email: "Bombay@gin.com"
        }
      ]
    };
  },
  methods: {},
  components: {}
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
