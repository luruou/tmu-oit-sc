<template>
  <SCHeader />
  <!--  <SCWeather :uri="scInfo.weatherAPI" /> -->
  <section class="board py-3 bg-primary bg-opacity-35 mb-5">
    <div class="container-fluid">
      <div
        class="row row-cols-2 justify-content-around align-items-center py-4"
      >
        <div class="col-lg-5 py-3 mx-auto text-break" style="width: 437px">
          <h1 class="fw-bolder room-title">{{ scInfo.name }}</h1>
          <span class="h5 round p-2 px-3 rounded-pill bg-teal-500 text-white">{{
            scInfo.comment
          }}</span>
        </div>
        <SCWeather :scId="$route.params.scId" />
      </div>
    </div>
  </section>
  <SCEvents :scId="$route.params.scId" />

  <!-- <h2>接駁車資訊</h2>
  <SCBus :scId="$route.params.scId" /> -->
  <SCFooter />
</template>
  <style scoped>
.container {
  max-width: 960px;
}

/*
 * Custom translucent site header
 */

.site-header {
  background-color: rgba(255, 255, 255, 0.85);
  -webkit-backdrop-filter: saturate(180%) blur(20px);
  backdrop-filter: saturate(180%) blur(20px);
}
.site-header a {
  color: #8e8e8e;
  transition: color 0.15s ease-in-out;
}
.site-header a:hover {
  color: #fff;
  text-decoration: none;
}

/*
 * Dummy devices (replace them with your own or something else entirely!)
 */

.product-device {
  position: absolute;
  right: 10%;
  bottom: -30%;
  width: 300px;
  height: 540px;
  background-color: #333;
  border-radius: 21px;
  transform: rotate(30deg);
}

.product-device::before {
  position: absolute;
  top: 10%;
  right: 10px;
  bottom: 10%;
  left: 10px;
  content: "";
  background-color: rgba(255, 255, 255, 0.1);
  border-radius: 5px;
}

.product-device-2 {
  top: -25%;
  right: auto;
  bottom: 0;
  left: 5%;
  background-color: #e5e5e5;
}

/*
 * Extra utilities
 */

.flex-equal > * {
  flex: 1;
}
@media (min-width: 768px) {
  .flex-md-equal > * {
    flex: 1;
  }
}
</style>


<script>
import SCHeader from "@/components/SCHeader.vue";
import SCWeather from "@/components/SCWeather.vue";
import SCEvents from "@/components/SCEvents.vue";
import SCFooter from "@/components/SCFooter.vue";
// import mitt from "mitt";
// const emitter = mitt();

export default {
  name: "SCDetailView",
  data() {
    return {
      scInfo: {},
    };
  },
  mounted() {
    console.log("mounted");
  },
  async beforeCreate() {
    console.log("before create");
    console.log(process.env.VUE_APP_SC_API);
    //let base = this;
    await this.axios
      .get(process.env.VUE_APP_SC_API + "/detail/" + this.$route.params.scId)
      .then((response) => {
        this.scInfo = response.data;
      });
    //api取得智慧教室資訊
    console.log(this.scInfo);
  },
  created() {
    console.log("created");
  },
  components: { SCHeader, SCWeather, SCEvents, SCFooter },
};
</script>
