<template>
<div class="container mx-auto">
    <CurrencyRates />
</div>
</template>

<script>
import CurrencyRates from './pages/CurrencyRates.vue';
import {
    defineComponent,
    onMounted
} from "vue";
export default defineComponent({
    components: {
        CurrencyRates
    },
})
</script>
