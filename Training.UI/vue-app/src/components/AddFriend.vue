<template>
<div class="card">
    <div class="card-body">
        <div class="container w-100">
            <div class="form-group my-1">
                <label for="name-input">Name</label>
                <input class="form-control" id="name-input" v-model="friend.name" placeholder="Friend's Name" type="text"/>
            </div>
            <div class="form-group my-1">
                <label for="phone-input">Phone Number</label>
                <input class="form-control" id="phone-input" v-model="friend.phone" placeholder="Friend's Phone Number" type="tel"/>
            </div>
            <div class="form-group my-1">
                <label for="email-input">Email Address</label>
                <div id="email-input" class="input-group my-1">
                    <input class="form-control" v-model="friend.email" placeholder="Friend's Email" type="email" aria-describedby="email-addon"/>
                    <div class="input-group-append">
                        <span id="email-addon" class="input-group-text px-1">@example.com</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="card-footer">
        <div class="container">
            <div class="d-block w-100">
                <button class="btn btn-primary float-right" @click="onSubmit">Submit</button>
            </div>
        </div>
    </div>
</div>
</template>

<script>
export default {
  emits: ["submit-friend"],
  data() {
    return {
      friend: {
        id: 0,
        name: "",
        phone: "",
        email: "",
        favorite: false
      }
    };
  },
  methods: {
    onSubmit() {
      this.$emit("submit-friend", this.friend);
    }
  }
};
</script>