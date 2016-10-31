<template>
  <transition
    @beforeEnter="beforeEnter"
    @afterEnter="afterEnter"
    @beforeLeave="beforeLeave"
    @leave="leave"
    @afterLeave="afterLeave"
    @leave-cancelled="leaveCancelled"
  >
    <slot></slot>
  </transition>
</template>

<script>
export default {
  methods: {
    beforeEnter (el) {
      this.cancelTransition() 
      el.classList.remove('collapse')
      el.style.display = 'block'
      el.classList.add('collapsing')
      el.style.height = `${el.scrollHeight}px`
    },
    afterEnter (el) {
      el.classList.remove('collapsing')
      el.classList.add('collapse', 'in')
      el.style.removeProperty('height');
    },
    beforeLeave (el) {
      el.style.height = `${el.scrollHeight}px`
      el.classList.remove('collapse', 'in')
    },
    leave (el) {
      window.setTimeout(() => {
        el.classList.add('collapsing')
        el.style.height = 0
      },0)
    },
    leaveCancelled (el){
      this.cancelTransition() 
    },
    afterLeave (el) {
      this.timeoutID =  window.setTimeout(() => {
        el.classList.remove('collapsing')
        el.classList.add('collapse')
        el.style.display = 'none'
        this.timeoutID = null
      }, 377) 
    },
    cancelTransition () {
      if (this.timeoutID){
        window.clearTimeout(this.timeoutID) 
        this.timeoutID = null
        console.log('cancelled')
      }
    }
  }
}
</script>

<style lang="scss">
.collapse {
  display: none;

  &.in {
    display: block;
  }
}

.collapsing {
  height: 0;
  overflow: hidden;
  transition: height .377s ease;
}
</style>

