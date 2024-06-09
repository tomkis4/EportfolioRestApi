<template>
    <div>
      <h2>Portfolio</h2>
      <ul>
        <li v-for="item in portfolioItems" :key="item.id">{{ item.name }}</li>
      </ul>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        portfolioItems: []
      };
    },
    created() {
      // Fetch data from API
      fetch('http://localhost:5243/api/portfolio')
        .then(response => response.json())
        .then(data => {
          this.portfolioItems = data;
        })
        .catch(error => {
          console.error('Error fetching portfolio items:', error);
        });
    }
  };
  </script>
  
  <style>
  /* Dodaj własne style tutaj */
  </style>
  