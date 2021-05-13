<template>
    <div class="card shadow">
        <div class="card-header">
            <h2>Name</h2>
            <h2 class="badge badge-primary font-lg px-5">{{userName}}</h2>
        </div>
        <div class="card-body">
            <h3>Age</h3>
            <h3 class="badge badge-secondary font-lg px-5">{{age}}</h3>
        </div>
    </div>
</template>

<script>
export default {
  props: {
    userName: {
      required: true,
      type: String
    },
    age: {
      required: true,
      type: Number
    }
  },
  data() {
    return {};
  },
  methods: {},
  components: {}
};
</script>