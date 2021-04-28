<template>
<div class="card">
    <div class="card-header">
        <h2 class="bg-purple rounded shadow text-white">{{ friend.name }}</h2>
        <button class="btn btn-danger" @click="toggleDetails">{{ detailsAreVisible ? 'Hide' : 'Show' }} Details</button>
    </div>
    <div class="card-body" v-if="detailsAreVisible">
        <ul class="list-group list-group-flush">
            <li class="list-group-item"><strong>Phone: </strong>{{ friend.phone }}</li>
            <li class="list-group-item"><strong>Email: </strong>{{ friend.email }}</li>
        </ul>
    </div>
    <div class="card-footer"></div>
</div>
</template>


<script>
export default {
  data() {
    return {
      detailsAreVisible: false,
      friend: {
        id: "2",
        name: "Friend 2",
        phone: "123 456 7891",
        email: "friend2@email.com"
      }
    };
  },
  methods: {
    toggleDetails() {
      this.detailsAreVisible = !this.detailsAreVisible;
    }
  }
};
</script>