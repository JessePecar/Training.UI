<template>
<div>
    <h2 class="w-100 text-center bg-purple text-white p-2 rounded shadow">My Friends</h2>
    <ul class="list-group list-group-flush">
      <li class="list-group-item" ><friend-contact></friend-contact></li>
      <li class="list-group-item" ><friend-contact></friend-contact></li>

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
          name: "Friend 1",
          phone: "123 456 7890",
          email: "friend1@email.com"
        },
        {
          id: "2",
          name: "Friend 2",
          phone: "123 456 7891",
          email: "friend2@email.com"
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
