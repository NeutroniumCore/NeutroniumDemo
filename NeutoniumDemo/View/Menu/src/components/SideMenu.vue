<template>
  <aside class="menu app-sidebar animated slideInLeft">
    <p class="menu-label">
      {{name}}
    </p>
    <ul class="menu-list">
      <li v-for="item in menuData.SubMenu">
        <expandable-menu :menu-data="item" :navigate="navigate" :getIcone="getIcone" :selected="selected">
        </expandable-menu>
      </li>
      <final-menu :menu-data="menuData" :navigate="navigate" :getIcone="getIcone" :selected="selected">
      </final-menu>
    </ul>
  </aside>
</template>

<script>
import ExpandableMenu from './ExpandableMenu'
import FinalMenu from './FinalMenu'

export default {
  name: 'SideMenu',

  components: {
    ExpandableMenu,
    FinalMenu
  },

  data(){
    return {
      icones:{
        About: 'home',
        Pages: 'television'
      },
      selected: null
    }
  },

  props: {
    name: String,
    menuData: {
      type: Object,
      required: true
    }
  },

  methods: {
    isExpanded (item) {
      return item.Expanded
    },

    toggle (item) {
      item.Expanded = !item.Expanded
    },

    navigate (item) {
      this.selected = item
      this.menuData.Navigate.Execute(item)
    },

    getIcone (item) {
      const resp = this.icones[item.Descriptor]
      return (!resp)? '' : resp;
    }
  }
}
</script>

<style lang="scss">

@import '~bulma/bulma';
@import '~font-awesome/css/font-awesome.css';

html {
  overflow-y: hidden;
  overflow-x: hidden; 
}

.app-sidebar {
  position: fixed;
  top: 0px;
  left: 0;
  bottom: 0;
  padding: 0px 0 50px;
  width: 180px;
  max-height: 100vh;
  z-index: 1024 - 1;
  background: #FFF;
  box-shadow: 0 2px 3px rgba(17, 17, 17, 0.1), 0 0 0 1px rgba(17, 17, 17, 0.1);
  overflow-y: auto;
  overflow-x: hidden;

  .icon {
    vertical-align: baseline;
    &.is-angle {
      position: absolute;
      right: 10px;
      transition: transform .377s ease;
    }
  }

  .menu-label {
    padding-left: 5px;
  }

  .menu-list {
    li a {
      &[aria-expanded="true"] {
        .is-angle {
          transform: rotate(180deg);
        }
      }
    }

    li a + ul {
      margin: 0 10px 0 15px;
    }
  }

}
</style>