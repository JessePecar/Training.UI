<template>
<div>
  
  <div class="w-100 bg-primary py-1" style="60px;">
        <button class="text-white mx-2 btn btn-dark p-3" @click="showPage(0)">Home</button>
        <button class="text-white mx-2 btn btn-dark p-3" @click="showPage(1)">Assignment 1</button>
  </div>
  <div class="container py-2">
    <friend :class="pageId === 0 ? '' : 'd-none'"></friend>
    <user :class="pageId === 1 ? '' : 'd-none'"></user>
  </div>
</div>

</template>

<script>
export default {
  data() {
    return {
      pageId: 1
    };
  },
  methods: {
    showPage(pageId) {
      this.pageId = pageId;
    }
  },
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
}
</style>
