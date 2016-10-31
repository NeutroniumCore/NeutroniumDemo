<template>
  <side-menu :menuData="viewModel">
  </side-menu>
</template>

<script>
import SideMenu from './components/SideMenu'

const props={
  viewModel: Object,
};

export default {
  components:{
    SideMenu
  },
  name: 'app',
  props
}
</script>

<style>
</style>
