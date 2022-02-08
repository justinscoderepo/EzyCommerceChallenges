<template>
<div>
    <Multiselect class="flex-column min-w-[280px] max-w-full" v-model="values" mode="tags" :close-on-select="true" :searchable="true" @change="onChange"  :create-option="true" :options="options" />
</div>
</template>

<script>
import Multiselect from '@vueform/multiselect'

export default {
    components: {
        Multiselect,
    },
    props: ['options','values','onChange'],
}
</script>

<style src="@vueform/multiselect/themes/default.css"></style>
