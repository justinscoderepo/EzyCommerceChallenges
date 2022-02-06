<template>
<div class="container mx-auto">
    <ReadList />
</div>
</template>

<script>
import ReadList from './pages/ReadList.vue';
import {
    defineComponent,
    onMounted
} from "vue";
export default defineComponent({
    components: {
        ReadList
    },
})
</script>
