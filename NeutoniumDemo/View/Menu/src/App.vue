<template>
    <side-menu :menuData="viewModel">
    </side-menu>
</template>

<script>
import SideMenu from './components/SideMenu'

const props={
    viewModel: Object,
    __window__: Object
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
