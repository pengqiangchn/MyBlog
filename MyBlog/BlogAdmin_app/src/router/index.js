import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import IView from '../views/iView.vue'

Vue.use(VueRouter)

const routes = [{
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about',
    name: 'About',
    component: () => import('../views/About.vue')
  },
  {
    path: '/iview',
    name: 'IView',
    component: IView
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router