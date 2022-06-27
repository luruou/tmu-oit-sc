<template>
  {{ bus.routeName }}
  <br />
  {{ bus.description }}
  <br />
  <template v-for="(b, key) in bus.times" :key="key">
    {{ b.current }}{{ b.time }}
    <br />
  </template>
</template>
<script>
// import mitt from "mitt";
// const emitter = mitt();
export default {
  name: "SCBus",
  props: ["scId"],
  data() {
    return {
      bus: {},
    };
  },
  async created() {
    console.log("scbus");

    this.bus = await this.fetchBus(this.scId);
    this.setCurrentBusTime();
    this.setBusTimeInterval();
  },
  methods: {
    async fetchBus(scId) {
      const url = process.env.VUE_APP_BUS_API + "/Time/" + scId;
      const d = new Date();
      let day = d.getDay();
      const response = await fetch(url);
      const bus = await response.json();

      bus.times = bus.times.filter((t) => t.weekDay == day);
      return bus;
    },
    setCurrentBusTime() {
      const now = new Date();
      let base = this;
      const getTime = (time) =>
        new Date(
          now.getFullYear(),
          now.getMonth(),
          now.getDate(),
          time.substring(0, 2),
          time.substring(3, 5),
          0,
          0
        );
      base.bus.times.forEach(function (item) {
        if (now < getTime(item.time)) item.current = "*";
      });
    },
    setBusTimeInterval() {
      let base = this;
      window.setInterval(async () => {
        base.bus = await this.fetchBus(base.scId);
        base.setCurrentBusTime();
      }, 60 * 1000);
    },
  },
};
</script>