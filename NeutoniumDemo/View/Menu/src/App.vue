<template>
  <div id="main">
    <img src="./assets/logo.png">
    <h2>Related Links</h2>
    <ul>
      <li><a href="https://vuejs.org" target="_blank">Core Vue Docs</a></li>
      <li><a href="https://forum.vuejs.org" target="_blank">Vue Forum</a></li>
      <li><a href="https://github.com/David-Desmaisons/Neutronium" target="_blank">Neutronium</a></li>
      <li><a href="https://github.com/David-Desmaisons/neutronium-vue" target="_blank">Neutronium Vue template</a></li>
      <li><a href="https://github.com/David-Desmaisons/NeutoniumDemo" target="_blank">Neutronium Vue application demo</a></li>
    </ul>
  </div>
</template>

<script>
const props={
  viewModel: Object,
};

export default {
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
