<template>
<div v-if="menuData.Children.length>0">
  <li v-for="item in menuData.Children">
    <a @click.prevent="navigate(item)" :class="{'is-active': (selected == item? true : false) }">
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
    navigate: {
      type: Function,
      required: true
    },
    getIcone: {
      type: Function,
      required: true
    },
    selected: Object
  }
}
</script>

<style lang="scss">
</style>