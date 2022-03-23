import Vue from 'vue'
import App from './App.vue'
import router from './router'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'
import VueAxios from 'vue-axios'
import Axios from 'axios'
import firebase from 'firebase'


Vue.config.productionTip = false


firebase.initialize({
    apiKey: "AIzaSyDCMLi0clzdhPWVBsVyHCqDu1Ox2uvjDCc",
    authDomain: "translate-948b4.firebaseapp.com",
    projectId: "translate-948b4",
    storageBucket: "translate-948b4.appspot.com",
    messagingSenderId: "80465427184",
    appId: "1:80465427184:web:7c1324ea0e461fa0a46035"
})

Vue.use(BootstrapVue);
Vue.use(IconsPlugin);
Vue.use(VueAxios, Axios);

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

new Vue({
    router,
    render: h => h(App)
}).$mount('#app')