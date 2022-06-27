<template>
  <!-- {{weatherElements}}<br />
  {{ this.wx }}<br />
  {{ this.t }}<br />
  {{ this.pop6h }}<br /> 
  {{ this.wxText }}<br />
  {{ this.tText }}°C<br />
  {{ this.pop6hText }}%<br />-->
  <div id="tmu-env-content" class="col-lg-5 py-3 bg-white rounded-15 rounded me-6">
    <div class="row px-3">
      <div class="col-8 d-flex flex-column text-dark lh-lg">
        <span>{{ scInfo.location }}</span>
        <span>{{ this.weather.wxCode }}{{ this.weather.wxText }}</span>
        <p class="text-dark">
          <i class="bi bi-thermometer"></i>
          {{ this.weather.tText }}°C
          <i class="bi bi-droplet-fill"></i>
          {{ this.weather.pop6hText }}%
        </p>
      </div>
      <div class="col-3">
        <img :src="weather.imgSrc" class="mx-auto d-block" width="120" />
      </div>
    </div>

    <!-- 營繕組環境data -->
    <div class="row mt-3 g-0">
      <div id="carousel-tmu" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-inner">
          <div class="carousel-item active">
            <div class="d-flex flex-row">
              <div class="col px-4">
                <span class="text-dark">
                  室內溫度
                  <i class="bi bi-thermometer"></i>
                </span>
                <h1 class="text-primary tmu-env-data py-0">
                  {{decimalPoint2(envMonitor.condistionValue)}}<span class="fs-3">°C</span>
                </h1>
              </div>
              <div class="col px-4">
                <span class="text-dark">
                  室內濕度
                  <i class="bi bi-droplet-fill"></i>
                </span>
                <h1 class="text-primary tmu-env-data">
                  50
                  <span class="fs-3">%</span>
                </h1>
              </div>
            </div>
          </div>
          <div class="carousel-item">
            <div class="d-flex flex-row">
              <div class="col px-4">
                <span class="text-dark">二氧化碳(ppm)</span>
                <h1 class="text-primary tmu-env-data py-0">{{envMonitor.co2Value}}</h1>
              </div>
              <div class="col px-4">
                <span class="text-dark">累積降雨量(mm)</span>
                <h1 class="text-primary tmu-env-data">{{envMonitor.threeHourRainValue}}</h1>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>

  <!-- <div class="col-lg-5 py-3 bg-white rounded-15 mx-auto rounded">
    <div class="row row-cols-2 px-3">
      <div class="col px-4 d-flex flex-column">
        <span class="text-dark">
          教室溫度
          <i class="bi bi-thermometer"></i>
        </span>
        <h1 class="text-primary room-title py-0">23°C</h1>
        <span class="text-dark">
          教室濕度
          <i class="bi bi-droplet-fill"></i>
        </span>
        <h1 class="text-primary room-title">88%</h1>
      </div>
      <div class="col d-flex flex-column text-dark">
        <span>{{ scInfo.location }}</span>
        <p class="text-dark">
          <i class="bi bi-thermometer"></i>
          {{ this.weather.tText }}°C
          <i class="bi bi-droplet-fill"></i>
          {{ this.weather.pop6hText }}%
        </p>
        <span>{{ this.weather.wxText }}</span>
        <img src="../assets/icons/sun.gif" class="mx-auto d-block" width="130" />
      </div>
      {{envMonitor.co2Value}}ppm{{decimalPoint2(envMonitor.condistionValue)}}°C{{envMonitor.tenMinutsRainValue}}mm{{envMonitor.hourRainValue}}mm{{envMonitor.threeHourRainValue}}mm
    </div>
  </div>-->
</template>
<script>
export default {
  name: "SCWeather",
  props: ["scId"],
  data() {
    return {
      scInfo: {},
  

      weatherAPIUrl: "",
      co2API: {
        url: "",
        body: {},
      },
      rainAPI: {
        url: "",
        body: {},
      },
      conditionAPI: {
        url: "",
        body: {},
      },
      weatherElements: {},
      weather: {
        wx: {},
        t: {},
        pop6h: {},
        wxText: "天氣現象",
        wxCode:"",
        tText: "--",
        pop6hText: "--",
        imgSrc: "",
      },
      envMonitor: {
        co2Value: 0,
        condistionValue: 0.0,
        tenMinutsRainValue: 0.0,
        hourRainValue: 0.0,
        threeHourRainValue: 0.0,
      },
    };
  },
  async created() {
    console.log("scweather created");
    let response = await fetch(
      process.env.VUE_APP_SC_API + "/detail/" + this.$route.params.scId
    );
    this.scInfo = await response.json();

    //中央氣象
    let weather = this.scInfo.webAPIs.find((a) => a.apiKey == "Weather");
    this.weatherAPIUrl = weather.apiUrl;
    this.weatherElements = await this.fetchWeatherElements(this.weatherAPIUrl);
    this.setWeatherElement();
      this.getWeatherImage();
    this.setWeatherInterval();

    //CO2
    let co2 = this.scInfo.webAPIs.find((a) => a.apiKey == "CO2");
    if (co2) {
      this.co2API.url = co2.apiUrl;
      this.co2API.body = co2.apiParameter ? JSON.parse(co2.apiParameter) : null;

      this.envMonitor.co2Value = await this.postCO2Sensors(
        this.co2API.url,
        this.co2API.body
      );
      this.setCO2Interval();
    }
    //降雨量
    let rain = this.scInfo.webAPIs.find((a) => a.apiKey == "Rain");
    if (rain) {
      this.rainAPI.url = rain.apiUrl;
      this.rainAPI.body = rain.apiParameter
        ? JSON.parse(rain.apiParameter)
        : null;
      let rainValue = await this.postRainSensors(
        this.rainAPI.url,
        this.rainAPI.body
      );
      this.envMonitor.tenMinutsRainValue = rainValue.tenMinutsRainValue;
      this.envMonitor.hourRainValue = rainValue.hourRainValue;
      this.envMonitor.threeHourRainValue = rainValue.threeHourRainValue;
      this.setRainInterval();
    }
    //空調
    let condition = this.scInfo.webAPIs.find((a) => a.apiKey == "Condition");
    if (condition) {
      this.conditionAPI.url = condition.apiUrl;
      this.conditionAPI.body = JSON.parse(condition.apiParameter);
      this.envMonitor.condistionValue = await this.postCondistionSensors(
        this.conditionAPI.url,
        this.conditionAPI.body
      );
      this.setConditionInterval();
    }
    //this.weatherAPI = scInfo.weatherAPI;
  },
  computed: {
    decimalPoint2() {
      return (v) => {
        // 截取當前數據到小數點後兩位
        let realVal = Number(v).toFixed(2);
        return Number(realVal);
      };
    },
  },
  methods: {
    async fetchWeatherElements(url) {
      const response = await fetch(url);
      const res = await response.json();
      return res.records.locations[0].location[0].weatherElement;
    },
    setWeatherInterval() {
      let base = this;
      window.setInterval(async () => {
        base.weatherElements = await this.fetchWeatherElements(
          base.weatherAPIUrl
        );
        await base.setWeatherElement();
        await base.getWeatherImage();
      }, 60 * 1000);
    },
    async setWeatherElement() {
      const now = new Date();
      let base = this;
      base.weatherElements.forEach((item) => {
        switch (item.elementName) {
          case "Wx":
            base.weather.wx = item.time.find(
              (x) => new Date(x.startTime) < now && now < new Date(x.endTime)
            );
            if (base.weather.wx == null) base.weather.wx = item.time[0];
            base.weather.wxText = base.weather.wx.elementValue[0].value;
            base.weather.wxCode = base.weather.wx.elementValue[1].value;


            break;
          case "T":
            base.weather.t = item.time.find(
              (x) =>
                new Date(x.dataTime) < now &&
                now <
                  new Date(x.dataTime).setHours(
                    new Date(x.dataTime).getHours() + 3
                  )
            );
            if (base.weather.t == null) base.weather.t = item.time[0];
            base.weather.tText = base.weather.t.elementValue[0].value;
            break;
          case "PoP6h":
            base.weather.pop6h = item.time.find(
              (x) => new Date(x.startTime) < now && now < new Date(x.endTime)
            );
            if (base.weather.pop6h == null) base.weather.pop6h = item.time[0];

            base.weather.pop6hText = base.weather.pop6h.elementValue[0].value;
            break;
          default:
        }
      });
    },
    async getWeatherImage()
    {
      let base = this;
      const response = await fetch(process.env.VUE_APP_CONFIG_API + "/weather/" + base.weather.wxCode);
      const res = await response.json();
      this.weather.imgSrc = res.value;
    },
    async postCO2Sensors(url, body) {
      const response = await this.axios.post(url, body);
      const res = await response.data.co2Sensors;
      let co2Value =
        res.map((el) => el.co2Value).reduce((a, b) => a + b, 0) / res.length;
      if (isNaN(co2Value)) co2Value = 0;
      return co2Value;
    },
    setCO2Interval() {
      let base = this;
      window.setInterval(async () => {
        base.envMonitor.co2Value = await base.postCO2Sensors(
          base.co2API.url,
          base.co2API.body
        );
      }, 60 * 1000);
    },

    async postRainSensors(url, body) {
      const response = await this.axios.post(url, body);
      const res = await response.data;
      return res;
    },

    setRainInterval() {
      let base = this;
      window.setInterval(async () => {
        let rainValue = await base.postRainSensors(
          base.rainAPI.url,
          base.rainAPI.body
        );
        base.envMonitor.tenMinutsRainValue = rainValue.tenMinutsRainValue;
        base.envMonitor.hourRainValue = rainValue.hourRainValue;
        base.envMonitor.threeHourRainValue = rainValue.threeHourRainValue;
        console.log("update rain");
      }, 60 * 1000);
    },

    async postCondistionSensors(url, body) {
      const response = await this.axios.post(url, body);

      const res = await response.data.condistionSensors;
      let conditionValue =
        res.map((el) => el.conditionTemp).reduce((a, b) => a + b, 0) /
        res.length;
      console.log(conditionValue);
      if (isNaN(conditionValue)) conditionValue = 0;

      return conditionValue;
    },
    setConditionInterval() {
      let base = this;
      window.setInterval(async () => {
        base.envMonitor.condistionValue = await base.postCondistionSensors(
          base.conditionAPI.url,
          base.conditionAPI.body
        );
        console.log("update condition");
      }, 60 * 1000);
    },
  },
};
</script>
