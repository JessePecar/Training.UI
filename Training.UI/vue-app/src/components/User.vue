<template>
    <div>
        <active-user class="my-3" :user-name="userName" :age="age"></active-user>
        
        <user-data class="my-3" @on-update-user="updateUser"></user-data>
    </div>
</template>

<script>
export default {
  data() {
    return {
      userName: "King Henry VIII",
      age: 0
    };
  },
  methods: {
    updateUser(name, age) {
      this.age = +age;
      this.userName = name;
    }
  },
  components: {}
};
</script>