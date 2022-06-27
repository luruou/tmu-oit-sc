import { createRouter, createWebHistory } from 'vue-router'
import SCView from '../views/SCView.vue'
import SCDetailView from '../views/SCDetailView.vue'
//import SCTestView from '../views/SCTestView.vue'
import HomeView from '../views/HomeView.vue'

const routes = [
  {
    path: '/index',
    component: SCView
  },
  {
    path:'/sc/:scId',
    component: SCDetailView
  },
  {
    path:'/',
    component: HomeView
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
