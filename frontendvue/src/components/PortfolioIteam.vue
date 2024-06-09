<template>
    <div v-if="portfolioItem">
      <h1>{{ portfolioItem.title }}</h1>
      <p>{{ portfolioItem.description }}</p>
      <a :href="portfolioItem.url">Visit</a>
    </div>
  </template>
  
  <script>
  import api from './api';
  
  export default {
    data() {
      return {
        portfolioItem: null
      };
    },
    props: ['id'],
    created() {
      api.getPortfolioItem(this.id).then(response => {
        this.portfolioItem = response.data;
      }).catch(error => {
        console.error(error);
      });
    }
  };
  </script>
  