<template>
  <!-- <h6>Listado de Digimones</h6> -->
  <div class="product-list">
    <div class="product-grid">
      <div class="product-item" v-for="item in filteredDigimones" :key="item.id">
        <DigimonItem :digimon="item" />
      </div>
    </div>
  </div>
</template>

<style>
.product-grid {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  grid-gap: 20px;
}
</style>

<script>
import DigimonItem from 'src/components/digimon/DigimonItem.vue'

export default {
  name: 'DigimonList',
  components: {
    DigimonItem,
  },
  props: {
    nivelFiltrado: {
      type: String,
      default: null,
    },
  },
  data() {
    return {
      digimones: [],
    }
  },
  mounted() {
    this.CargarDigimones()
  },
  computed: {
    filteredDigimones() {
      if (this.nivelFiltrado) {
        return this.digimones.filter(
          (digimon) => digimon.level === this.nivelFiltrado
        )
      }
      return this.digimones
    },
  },
  methods: {
    CargarDigimones() {
      console.log('Cargando Digimones...')
      let endpointURL = '/api/digimon'

      this.$api2
        .get(endpointURL)
        .then((response) => {
          this.digimones = response.data
          console.log('Digimones:', this.digimones)
      })
        .catch((error) => {
          console.error('Error al cargar Digimones:', error)
        })
    },
  }
}
</script>
