<template>
    <neutronium-main-window name="fade" :window="__window__">
        <img src="./assets/logo.png">
        <h1>Page 2</h1>
    </neutronium-main-window>
</template>

<script>
import NeutroniumMainWindow from 'neutronium-main-window'

const props={
    viewModel: Object,
    __window__: Object
};

export default {
  components:{
    NeutroniumMainWindow
  },
  name: 'app',
  props,
  data () {
    return this.viewModel
  }
}
</script>

<style>
    #main {
        font-family: 'Avenir', Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 60px;
    }

    .fade-enter-active, .fade-leave-active {
        transition: opacity .2s;
    }

    .fade-enter, .fade-leave-active {
        opacity: 0;
    }

    img {
        height: 300px;
    }

    h1, h2 {
        font-weight: normal;
    }

    ul {
        list-style-type: none;
        padding: 0;
    }

    li {
        display: inline-block;
        margin: 0 10px;
    }

    a {
        color: #42b983;
    }
</style>
