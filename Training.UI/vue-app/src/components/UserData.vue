<template>
    <div class="card shadow">
        <div class="card-header">
            <h2>Enter User Details</h2>
        </div>
        <div class="card-body">
            <input v-model="userName" class="my-2 form-control"/>
            <input type="number" v-model="age" class="my-2 form-control"/>
        </div>
        <div class="card-footer d-block">
            <button class="btn btn-success float-right" @click="onSubmit">Save</button>
        </div>
    </div>
</template>

<script>
export default {
  emits: ["on-update-user"],
  data() {
    return {
      userName: "",
      age: 0
    };
  },
  methods: {
    onSubmit() {
      this.$emit("on-update-user", this.userName, this.age);
    }
  },
  components: {}
};
</script>