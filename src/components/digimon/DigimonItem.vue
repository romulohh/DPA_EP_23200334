<template>
  <q-card class="product-card">
    <q-card-section>
      <q-img :src="digimon.img" alt="Imagen del digimon" />
    </q-card-section>
    <q-card-section>
      <div class="text-h7">Nombre: <b>{{ digimon.name }}</b></div>
      <div class="text-h7">Nivel: <b>{{ digimon.level }}</b></div>
    </q-card-section>
  </q-card>
</template>

<style>
.product-card {
  width: 300px;
}
.product-card q-card-section {
  height: 100px;
  overflow: hidden;
}
</style>

<script>
export default {
  name: 'DigimonItem',
  props: {
    digimon: {
      type: Object,
      required: true,
    },
  },
}
</script>
