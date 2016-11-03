<template>
<div v-if="menuData.Children.length>0">
  <li v-for="item in menuData.Children">
    <a @click.prevent="root.CurrentMenuView = item" class="menu-item" :class="{'is-active': (root.CurrentMenuView == item? true : false) }">
      <span class="icon is-small"><i :class="['fa', 'fa-'+ getIcone(item)]"></i></span>
      {{ item.Name }}
    </a>
  </li>
  <div>
</template>

<script>
export default {
  props: {
    menuData: {
      type: Object,
      required: true
    },
    root: {
      type: Object,
      required: true
    },
    getIcone: {
      type: Function,
      required: true
    }
  }
}
</script>

<style lang="scss">
.menu-item {
  transition: background-color 0.3s ease;
  transition: color 0.3s ease;
}
</style>