<template>
      <li>
       <a @click.prevent="toggle(menuData)" :aria-expanded="menuData.Expanded ? 'true' : 'false'">
          <span class="icon is-small"><i :class="['fa', 'fa-'+getIcone(menuData)]"></i></span>
          {{ menuData.Name }}
          <span class="icon is-small is-angle">
            <i class="fa fa-angle-down"></i>
          </span>
        </a>
        <expandable v-if="menuData.Children.length || menuData.SubMenu.length" v-show="menuData.Expanded">
          <ul >
            <li v-for="subItem in menuData.SubMenu">
              <expandable-menu :menu-data="subItem" :root="root" :getIcone="getIcone">
              </expandable-menu>
            </li>
            <final-menu :menuData="menuData" :root="root" :getIcone="getIcone">
            </final-menu>
          </ul>
        </expandable>
      </li>
</template>

<script>
import Expandable from './Expandable'
import FinalMenu from './FinalMenu'

export default {
  name: 'ExpandableMenu',

  components: {
    Expandable,
    FinalMenu
  },

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
  },

  methods: {
    toggle (item) {
      item.Expanded = !item.Expanded
    }
  }
}
</script>

<style lang="scss">
</style>