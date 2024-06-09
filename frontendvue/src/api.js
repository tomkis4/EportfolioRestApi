import axios from 'axios';

const apiClient = axios.create({
    baseURL: 'http://localhost:5000/api',
    withCredentials: false,
    headers: {
        Accept: 'application/json',
        'Content-Type': 'application/json'
    }
});

export default {
    getPortfolioItems() {
        return apiClient.get('/portfolio');
    },
    getPortfolioItem(id) {
        return apiClient.get(`/portfolio/${id}`);
    }
};
