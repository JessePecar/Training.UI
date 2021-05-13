<template>
<div class="card">
    <div class="card-header">
        <h2 class="bg-purple rounded shadow text-white">{{ name }} {{isFavorite ? '(Favorite)' : '' }}</h2>
        <button class="btn btn-danger mx-1" @click="toggleDetails">{{ detailsAreVisible ? 'Hide' : 'Show' }} Details</button>
        <button class="btn btn-danger mx-1" @click="toggleFavorite">{{isFavorite ? 'Unfavorite' : 'Favorite' }}</button>
        
    </div>
    <div class="card-body" v-if="detailsAreVisible">
        <ul class="list-group list-group-flush">
            <li class="list-group-item"><strong>Phone: </strong>{{ phoneNumber }}</li>
            <li class="list-group-item"><strong>Email: </strong>{{ emailAddress }}</li>
        </ul>
    </div>
    <div class="card-footer">
      <div class="w-100 d-block">
        <button class="btn btn-danger mx-1 float-right" @click="deleteFriend">Delete</button>
      </div>
    </div>
</div>
</template>


<script>
export default {
  props: {
    id: {
      required: true,
      type: Number
    },
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
  emits: ["toggle-favorite", "delete-friend"],
  data() {
    return {
      detailsAreVisible: false
    };
  },
  methods: {
    toggleDetails() {
      this.detailsAreVisible = !this.detailsAreVisible;
    },
    toggleFavorite() {
      //Add Validation to the inputs
      this.$emit("toggle-favorite", this.id);
    },
    deleteFriend() {
      this.$emit("delete-friend", this.id);
    }
  }
};
</script>