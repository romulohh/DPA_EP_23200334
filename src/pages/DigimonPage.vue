<template>
  <q-layout view="hHr lpR fFf">
    <q-page-container>
      <div class="contenedor">
        <!-- Filtros a la izquierda -->
        <div class="filtros">
          <div class="card">
            <div class="text-h6">Filtros</div>
            <NivelFilter @nivelChanged="updateNivel" />
          </div>
        </div>

        <!-- Catálogo a la derecha -->
        <DigimonList :nivelFiltrado="nivelSelected" />
      </div>
    </q-page-container>
  </q-layout>
</template>

<style>
.contenedor {
  display: flex;
  gap: 20px;
  padding: 20px;
}

/* Filtros a la izquierda */
.filtros {
  flex: 3;    /* ocupa menos espacio */
}

/* Card genérica */
.card {
  border: 1px solid #ccc;
  border-radius: 8px;
  padding: 16px;
  background: #fff;
  box-shadow: 0 2px 4px rgba(0,0,0,0.1);
}

.product-list {
  width: 75%;
}
/* En pantallas pequeñas, apilar filtros arriba y catálogo abajo */
@media (max-width: 768px) {
  .contenedor {
    grid-template-columns: 1fr; /* una sola columna */
  }
}
/* En pantallas pequeñas, apilar */
@media (max-width: 768px) {
  .contenedor {
    flex-direction: column;
  }
}
</style>

<script>
import NivelFilter from 'src/components/digimon/NivelFilter.vue'
import DigimonList from 'src/components/digimon/DigimonList.vue'
export default {
  name: 'DigimonPage',
  components: {
    DigimonList,
    NivelFilter,
  },
    data() {
      return {
        nivelSelected: null,
      }
    },
  methods: {
    updateNivel(nivel) {
      console.log('Nivel seleccionado:', nivel)
      // Aquí puedes agregar la lógica para filtrar los productos según el nivel seleccionado
      this.nivelSelected = nivel
    },
  },
}
</script>
