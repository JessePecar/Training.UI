<template>
<div class="card">
    <div class="card-header">
        <h2 class="bg-purple rounded shadow text-white">{{ name }} {{friendIsFavorite ? '(Favorite)' : '' }}</h2>
        <button class="btn btn-danger mx-1" @click="toggleDetails">{{ detailsAreVisible ? 'Hide' : 'Show' }} Details</button>
        <button class="btn btn-danger mx-1" @click="toggleFavorite">{{friendIsFavorite ? 'Unfavorite' : 'Favorite' }}</button>
    </div>
    <div class="card-body" v-if="detailsAreVisible">
        <ul class="list-group list-group-flush">
            <li class="list-group-item"><strong>Phone: </strong>{{ phoneNumber }}</li>
            <li class="list-group-item"><strong>Email: </strong>{{ emailAddress }}</li>
        </ul>
    </div>
    <div class="card-footer"></div>
</div>
</template>


<script>
export default {
  props: {
    name: {
      required: true,
      type: String,
      validator: function(value) {
        return value != "";
      }
    },
    phoneNumber: {
      required: true,
      type: String
    },
    emailAddress: {
      required: true,
      type: String
    },
    isFavorite: {
      type: Boolean,
      required: false,
      default: false
    }
  },
  data() {
    return {
      detailsAreVisible: false,
      friendIsFavorite: this.isFavorite
    };
  },
  methods: {
    toggleDetails() {
      this.detailsAreVisible = !this.detailsAreVisible;
    },
    toggleFavorite() {
      this.friendIsFavorite = !this.friendIsFavorite;
    }
  }
};
</script>