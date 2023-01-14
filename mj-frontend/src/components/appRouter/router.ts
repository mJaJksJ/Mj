import VkModule from "../../pages/vk/VkModule";
import HabrModule from "../../pages/habr/HabrModule";

export const privateRoutes = [
  { path: '/', component: VkModule, exact: true, },
]

export const publicRoutes = [
  { path: '/Mj', component: VkModule, exact: true, },
  { path: '/vk', component: VkModule, exact: true },
  { path: '/habr', component: HabrModule, exact: true },
  { path: '/', component: VkModule, exact: true, },
]