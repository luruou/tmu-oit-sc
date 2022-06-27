<template>
  <header class="site-header sticky-top shadow-sm">
    <nav
      class="
        container
        d-flex
        flex-md-row
        justify-content-between
        align-items-stretch
        pb-0
        mt-2
      "
      style="padding: 10px"
    >
      <a class="navbar-brand d-inline-block">
        <img src="https://www.tmu.edu.tw/images/title.png" width="165" />
      </a>

      <div class="row row-cols-2 d-flex flex-row align-items-stretch">
        <div class="col">
          <h6 class="d-block">
            {{
              date.year +
              "/" +
              date.month +
              "/" +
              date.day
            }}
          </h6>
          <h6 class="d-block mb-0">{{ date.week }}</h6>
        </div>
        <div class="col">
          <span class="d-inline-block fs-1">
            {{
              date.hour +
              ":" +
              date.min +
              ":" +
              date.sec
            }}</span
          >
        </div>
      </div>
    </nav>
  </header> 
</template>

<style scoped>
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
</style>

<script>
export default {
  name: "SCHeader",
  data() {
    return {
      date: {
        year: "0000",
        month: "00",
        day: "00",
        hour: "00",
        min: "00",
        sec: "00",
        week: "",
      },
    };
  },
  created() {
    let base = this;
    //設定時間
    window.setInterval(() => {
      base.date = base.getFullDateTime();
    }, 1000);
  },
  methods: {
    getFullDateTime() {
      const dNames = new Array(
        "星期日",
        "星期一",
        "星期二",
        "星期三",
        "星期四",
        "星期五",
        "星期六"
      );
      const d = new Date();
      let date = {
        year: d.getFullYear(),
        month: (d.getMonth() + 1).toString().padStart(2,"0"),
        day: d.getDate().toString().padStart(2,"0"),
        hour: d.getHours().toString().padStart(2,"0"),
        min: d.getMinutes().toString().padStart(2,"0"),
        sec: d.getSeconds().toString().padStart(2,"0"),
        week: dNames[d.getDay()],
      };
      return date;
    },
  },
};
</script>




