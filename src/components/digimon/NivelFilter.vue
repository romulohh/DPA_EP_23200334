<template>
  <div class="nivel-filter">
    <q-select label="Nivel" v-model="nivelSelected" :options="opcionesFiltro" option-value="id" option-label="descripcion"
      emit-value map-options @update:model-value="onChange" />
  </div>
</template>

<style></style>

<script>
export default {
  name: 'NivelFilter',
  data() {
  return {
    nivelSelected: null,
    opcionesFiltro: [
      { descripcion: 'In Training', id: 'In Training' },
      { descripcion: 'Rookie', id: 'Rookie' },
      { descripcion: 'Champion', id: 'Champion' }
    ]
  }

  },
  methods: {
    onChange(value) {
      console.log('Nivel seleccionado en NivelFilter:', value)
      this.$emit('nivelChanged', value)
    },
  },
}
</script>
