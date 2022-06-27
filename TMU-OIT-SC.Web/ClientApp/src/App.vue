<template>
  <router-view />
</template>


<style lang="scss">
@import "./assets/all";
</style>

<style>
#app {
  /* font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50; */
  background-image: url("assets/SC_Background.jpg");
   background-repeat: no-repeat;
   background-size:1080px; 
}
body{
  /* background-color:rgb(245, 245, 245); */
  background-color:#F2F6F7;
  /* 漸層色 */
  /* background: linear-gradient(to right, #16b2c6, #92efeb); */
}

nav {
  padding: 30px;
}

nav a {
  font-weight: bold;
  color: #2c3e50;
}

nav a.router-link-exact-active {
  color: #42b983;
} 
</style>
<script>
export default {

}
</script>