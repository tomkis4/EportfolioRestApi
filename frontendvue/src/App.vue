<template>
  <div id="app">
    <header>
      <h1>Moje ePortfolio</h1>
    </header>
    <main>
      <PortfolioList />
    </main>
  </div>
</template>

<script>
import PortfolioList from './components/PortfolioList.vue';

export default {
  name: 'App',
  components: {
    PortfolioList
  }
};
</script>

<style>
/* Dodaj własne style tutaj */
</style>
