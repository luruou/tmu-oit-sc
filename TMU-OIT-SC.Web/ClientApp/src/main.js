import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import axios from 'axios'
import VueAxios from 'vue-axios'

//import $ from 'jquery'
//import mitt from 'mitt'
//import './utils/mixin.js'

//import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-icons/font/bootstrap-icons.css'

import VueSweetalert2 from 'vue-sweetalert2';
import 'sweetalert2/dist/sweetalert2.min.css';
import 'animate.css'

window.$ = window.jQuery = require('jquery');
//const emitter = mitt();
const app = createApp(App).use(router)
app.use(VueAxios, axios)
app.use(VueSweetalert2);
app.provide('axios', app.config.globalProperties.axios)  // provide 'axios'
app.mount('#app')
