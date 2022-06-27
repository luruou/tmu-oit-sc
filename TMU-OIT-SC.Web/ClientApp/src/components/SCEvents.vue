<template>
  <main>
    <input type="text" class="form-control" v-model="testDate" />
    <button type="button" class="btn btn-info" v-on:click="resetCurrent">Reset Current</button>
    <button type="button" class="btn btn-info" v-on:click="reloadEvent">Reload Event</button>
    <button type="button" class="btn btn-warning" v-on:click="testSwal">test swal</button>
    <template id="my-template">
  <swal-title>
    Save changes to "Untitled 1" before closing?
  </swal-title>
  <swal-icon type="warning" color="red"></swal-icon>
  <swal-button type="confirm">
    Save As
  </swal-button>
  <swal-button type="cancel">
    Cancel
  </swal-button>
  <swal-button type="deny">
    Close without Saving
  </swal-button>
  <swal-param name="allowEscapeKey" value="false" />
  <swal-param
    name="customClass"
    value='{ "popup": "my-popup" }' />
</template>
    <section class="container">

      <div class="row row-cols-1">
        <template v-if="events.length > 0">
          <div v-for="(event, key) in events" :key="key">
            <template v-if="event.current == '*' ">
              <div class="col p-1 card border-0 bg-teal rounded-15 shadow mb-5">
                <div class="bg-white rounded-15">
                  <div class="d-flex flex-row justify-content-between text-center">
                    <div class="col h1 py-3 my-0 fw-bold bg-secondary bg-opacity-50 rounded-top-left-15">{{ event.timeRange }}</div>
                    <div class="col h1 py-3 my-0 fw-bold rounded-top-right-15" style="background-color: #ffd900">上課中</div>
                  </div>
                  <div class="card-body px-4">
                    <div class="row row-cols-1">
                      <div class="col mb-4">
                        <div class="card-text h4 my-3">課號 {{ event.eventID }}</div>
                        <h1 class="card-title">
                          <strong v-on:click.prevent="showContent(event)" class="mb-2 course-name">{{ event.content }}</strong>
                        </h1>
                      </div>
                    </div>
                  </div>
                  <div class="d-flex flex-row ps-4 pt-2 pb-2 align-items-center">
                    <template v-for="(u, key) in event.users" :key="key">
                      <template v-if="u.imageBase64">
                        <div class="my-avatar-circle">
                          <!-- 男師圖：user-m.png；女師圖：user-f.png -->
                          <img id="qr" :src="u.imageBase64" class="avatar-img rounded mx-auto d-block" />
                        </div>
                      </template>
                      <template v-else>
                        <div class="my-avatar-circle">
                          <!-- 男師圖：user-m.png；女師圖：user-f.png -->
                          <img src="../assets/user-m.png" class="avatar-img rounded mx-auto d-block" />
                        </div>
                        <!-- <div class="p-2 pe-0 ps-4">
                            <img
                              src="../assets/user-man-icon.png"
                              style="width: 50px"
                            />
                        </div>-->
                      </template>
                      <div class="p-2 px-4 me-auto">
                        <div class="card-text mb-1">任課教師</div>
                        <h3 class="fw-bolder">{{ u.name }}</h3>
                      </div>
                    </template>
                    <!-- 簽到按鈕Group  -->
                    <div class="p-2 px-4 d-flex flex-row">
                      <button type="button" class="sign-button btn border border-3 btn-lg ms-1 disabled">已簽到 38</button>
                      <template v-if="event.currentSignIn == '*'">
                        <button type="button" class="sign-button btn btn-primary btn-lg ms-1" v-on:click="showSignModal('signInModal',event)">簽到</button>
                      </template>
                      <template v-if="event.currentSignOut == '*'">
                        <button type="button" class="sign-button btn btn-red-200 btn-lg ms-1" v-on:click="showSignModal('signOutModal',event)">簽退</button>
                      </template>
                    </div>
                    <!-- 簽到按鈕Group 結束  -->
                  </div>

                  <div class="card-footer border-top rounded-bottom-15 text-muted small px-4 py-3" style="min-height: 60px">
                    <!-- <p class="card-text mb-auto">
                        <i class="bi bi-info-circle"></i>很多的話想說只能在這裡說
                      </p>
                      <p class="card-text mb-auto">
                        <i class="bi bi-info-circle"></i>很多的話想說只能在這裡說
                    </p>-->
                  </div>
                </div>
              </div>
            </template>
            <template v-else-if="event.current == '-' || event.currentSignOut == '*'">
              <div class="col p-0">
                <div class="d-flex flex-row rounded-10 shadow mb-5 bg-white">
                  <div class="py-4 px-4 bg-secondary bg-opacity-25 rounded-start-10 d-block">{{ event.timeRange }}</div>
                  <div class="py-4 px-4 me-auto d-flex flex-column justify-content-start">
                    <span v-on:click.prevent="showContent(event)" class="d-inline-block text-truncate course-name" style="max-width: 500px">{{ event.content }}</span>
                    <template v-for="(u, key) in event.users" :key="key">
                      <span class="d-inline-block text-truncate" style="max-width: 500px">{{ u.name }}</span>
                    </template>
                  </div>
                  <div class="py-4 px-4 align-self-center">
                    <a href="#" class="sign-button btn btn-secondary text-opacity-25 btn-lg mb-1 disabled">即將開始</a>
                    <template v-if="event.currentSignIn == '*'">
                      <button type="button" class="sign-button btn btn-primary btn-lg ms-1" v-on:click="showSignModal('signInModal',event)">簽到</button>
                    </template>
                    <template v-if="event.currentSignOut == '*'">
                      <button type="button" class="sign-button btn btn-red-200 btn-lg ms-1" v-on:click="showSignModal('signOutModal',event)">簽退</button>
                    </template>
                    <!-- <a href="#" class="sign-button btn border">已簽到 38</a> -->
                  </div>
                </div>

                <div class="card border border-0 shadow"></div>
              </div>
            </template>
          </div>

        </template>

        <template v-else>
          <!-- 無行程 -->
          <div class="col p-0">
            <div class="d-flex flex-row rounded-10 shadow mb-5 bg-white">
              <div class="py-4 px-4 bg-secondary bg-opacity-25 rounded-start-10 d-block">00:00</div>
              <div class="py-4 px-4 me-auto d-flex flex-column justify-content-start">
                <span class="d-inline-block text-truncate course-name" style="max-width: 500px">今日無行程</span>
              </div>
              <div class="py-4 px-4 align-self-center">
                <button type="button" class="sign-button btn btn-primary btn-lg ms-1" v-on:click="showSignInModal(event)">TEST</button>
              </div>
            </div>

            <div class="card border border-0 shadow"></div>
          </div>

        </template>
      </div>

    </section>
  </main>

  <div class="modal fade signModal" id="signInModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true" @keyup="signIn">
    <div id="sign-body" class="modal-dialog modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="exampleModalLabel">簽到</h5>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <div class="modal-body" style="background-color:aquamarine">
          {{currentSignEvent.content}} {{currentSignEvent.memo}} 簽到畫面<br/>
          {{signInText}}
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        </div>
      </div>
    </div>
  </div>
  <div class="modal fade signModal" id="signOutModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true" @keyup="signOut">
    <div id="sign-body" class="modal-dialog modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title" id="exampleModalLabel">簽退</h5>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <div class="modal-body" style="background-color:lightpink">
          {{currentSignEvent.content}} {{currentSignEvent.memo}} 簽退畫面
          {{signOutText}}
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        </div>
      </div>
    </div>
  </div>
</template>

<style scoped>
/*簽到按鈕*/
.sign-button {
  width: 180px;
  font-weight: bold;
  letter-spacing: 3px;
}
</style>

<script>
import * as bootstrap from "bootstrap";

export default {
  name: "SCEvent",
  props: ["scId"],
  data() {
    return {
      events: [],
      currentSignEvent: {},
      signUser:{},
      cardValue: "",
      testDate: "06-24-2022 09:01:00",
    };
  },
  async created() {
    console.log("scevent");

    let base = this;
    //api取得課堂資訊
    base.events = await base.fetchEvents(base.scId);
    base.setCurrentEvent();
    base.setEventInterval();

    var elements = document.getElementsByClassName("signModal");
    console.log("elements");
    console.log(elements);
    for (let i = 0; i < elements.length; i++) {
      elements[i].addEventListener("hidden.bs.modal", function () {
        console.log("modal leave");
        base.signUser = {};
        base.cardValue = "";
      });
    }
  },
  computed: {
    signInText: function() {

      return this.signUser.name ? this.signUser.userID +' '+  this.signUser.name + ' ' + this.signUser.signDateTime  + ' 簽到成功' : '';
    },
    signOutText: function() {
      return this.signUser.name ? this.signUser.userID +' '+  this.signUser.name + ' ' + this.signUser.signDateTime  + ' 簽退成功' : '';
    },
  },
  methods: {
    testSwal(){

      this.$swal.fire({
  template: '#my-template'
})
    },
    getDate() {
      if (this.testDate) return new Date(this.testDate);
      else return new Date();
    },
    getDateTimeType(date) {
      return (
        date.getFullYear() +
        "-" +
        (date.getMonth() + 1).toString().padStart(2, "0") +
        "-" +
        date.getDate().toString().padStart(2, "0") +
        "T" +
        date.getHours().toString().padStart(2, "0") +
        ":" +
        date.getMinutes().toString().padStart(2, "0") +
        ":" +
        date.getSeconds().toString().padStart(2, "0") +
        "." +
        date.getMilliseconds().toString().padStart(3, "0")
      );
    },
    resetCurrent() {
      this.setCurrentEvent();
    },
    async reloadEvent() {
      this.events = await this.fetchEvents(this.scId);
      this.setCurrentEvent();
    },
    async sign(signIn, event) {
      console.log(event);
      let base = this;
      if (event.keyCode == 13) {
        let user = this.currentSignEvent.subUsers.find(
          (s) => s.cardID == this.cardValue
        );
        console.log(user);
        if (user) {
          let sign = {};
          sign.eventID = this.currentSignEvent.eventID;
          sign.eventType = this.currentSignEvent.type;
          sign.userID = user.userID;
          sign.signDateTime = this.getDateTimeType(new Date());
          sign.signIn = signIn;
          sign.name = user.name;
          await base.axios
          .post(process.env.VUE_APP_ATT_API + "/sign", sign)
          .then((res) => {
           
            base.signUser = sign;
            console.table(res.data);
          })
          .catch((error) => {
            console.log(error);
            this.$swal.fire({
  icon: 'error',
  title: '簽到退異常',
  text: 'Something went wrong!',
})
          })
          .finally(() => {});
        } else {
          //未在修課名單內
        }
        this.cardValue = "";
      } else if (event.key != "Shift" && event.key != "Control") {
        this.cardValue += event.key;
        console.log(this.cardValue);
      }
    },
    signIn(event) {
      this.sign(true, event);
    },
    signOut(event) {
      this.sign(false, event);
    },
    showSignModal(modal, event) {


      var modelEl = document.getElementById(modal);
      var options = {
        keyboard: false,
        focus: true,
      };
      var signModal = new bootstrap.Modal(modelEl, options);
      this.currentSignEvent = event;
      signModal.show();
    },
    arrayBufferToBase64(buffer) {
      var binary = "";
      var bytes = new Uint8Array(buffer);
      var len = bytes.byteLength;
      for (var i = 0; i < len; i++) {
        binary += String.fromCharCode(bytes[i]);
      }
      return window.btoa(binary);
    },
    async fetchEvents(scId) {
      let value = {};
      value.SCID = scId;
      value.Date = this.getDateTimeType(this.getDate());
      let events = await this.axios
        .post(process.env.VUE_APP_SC_API + "/event", value)
        .then((response) => response.data);

      //let events = await base.axios.get(url).then((response) => response.data);
      return events;
    },
    getTime(time) {
      const now = this.getDate();
      return new Date(
        now.getFullYear(),
        now.getMonth(),
        now.getDate(),
        time.substring(0, 2),
        time.substring(3, 5),
        0,
        0
      );
    },
    setCurrentFlag(item) {
      const now = this.getDate();
      if (now > this.getTime(item.start) && now < this.getTime(item.end))
        return "*";
      else if (now < this.getTime(item.start)) return "-";
      else return "";
    },
    setCurrentSignInFlag(item) {
      const now = this.getDate();
      if (
        now > this.getTime(item.signInStart) &&
        now < this.getTime(item.signInEnd)
      )
        return "*";
      else return "";
    },
    setCurrentSignOutFlag(item) {
      const now = this.getDate();
      if (
        now > this.getTime(item.signOutStart) &&
        now < this.getTime(item.signOutEnd)
      )
        return "*";
      else return "";
    },
    setCurrentEvent() {
      let base = this;

      //base.events = base.events.filter((e) => e.status != 8);

      console.log("==set current event==");
      base.events.forEach(function (item) {
        //console.log(item);
        item.current = base.setCurrentFlag(item);
        item.currentSignIn = base.setCurrentSignInFlag(item);
        item.currentSignOut = base.setCurrentSignOutFlag(item);
      });
      //base.events = base.events.filter((e) => e.current != "");
      console.log("base.events");
      console.log(base.events);
    },

    setEventInterval() {
      let base = this;
      window.setInterval(async () => {                                                                                                                                                         
        const now = this.getDate();
        const t1 = new Date(
          now.getFullYear(),
          now.getMonth(),
          now.getDate(),
          0,
          0,
          0,
          0
        );
        const t2 = new Date(
          now.getFullYear(),
          now.getMonth(),
          now.getDate(),
          0,
          10,
          0,
          0
        );
        //淩晨00:00:00~00:10:00 更新課表
        //else 計算目前課堂
        if (t1.getTime() < now.getTime() && now.getTime() < t2.getTime()) {
          console.log("fetch event");
          base.events = await base.fetchEvents(base.scId);
          base.setCurrentEvent(base.events);
        } else {
          console.log("set current event");
          base.setCurrentEvent(base.events);
        }
      }, 60 * 1000);
    },
    showContent(event) {
      console.log(event);

      this.$swal.fire({
        title: event.content,
        showClass: {
          popup: "animate__animated animate__zoomIn",
        },
        hideClass: {
          popup: "animate__animated animate__zoomOut",
        },
        html: event.memo,
        timer: 5000,
        timerProgressBar: true,
        showConfirmButton: false,
        didOpen: (toast) => {
          toast.addEventListener("mouseenter", this.$swal.stopTimer);
          toast.addEventListener("mouseleave", this.$swal.resumeTimer);
        },
      });
    },
  },
};
</script>