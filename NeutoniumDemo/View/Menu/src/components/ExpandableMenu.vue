<template>
      <li>
       <a @click.prevent="toggle(menuData)" :aria-expanded="isExpanded(menuData) ? 'true' : 'false'">
          <span class="icon is-small"><i :class="['fa', 'fa-'+getIcone(menuData)]"></i></span>
          {{ menuData.Name }}
          <span class="icon is-small is-angle">
            <i class="fa fa-angle-down"></i>
          </span>
        </a>
        <expandable v-if="menuData.Children.length || menuData.SubMenu.length" v-show="isExpanded(menuData)">
          <ul >
            <li v-for="subItem in menuData.SubMenu">
              <expandable-menu :menu-data="subItem" :navigate="navigate" :getIcone="getIcone" :selected="selected">
              </expandable-menu>
            </li>
            <final-menu :menuData="menuData" :navigate="navigate" :getIcone="getIcone" :selected="selected">
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
    navigate: {
      type: Function,
      required: true
    },
    getIcone: {
      type: Function,
      required: true
    },
    selected: Object
  },

  methods: {
    isExpanded (item) {
      return item.Expanded
    },

    toggle (item) {
      item.Expanded = !item.Expanded
    }
  }
}
</script>

<style lang="scss">
</style>