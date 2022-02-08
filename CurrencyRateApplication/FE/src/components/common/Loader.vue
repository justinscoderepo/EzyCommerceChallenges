<!-- This example requires Tailwind CSS v2.0+ -->
<template>
<div class="border border-blue-300 shadow rounded-md p-4 max-w-sm" v-bind:class="class" v-for="index in parseInt(count)" :key="index">
    <div class="animate-pulse flex space-x-4">
        <div class="flex-1 space-y-6 py-1">
            <div class="space-y-3">
                <div class="grid grid-cols-3 gap-4">
                    <div class="h-2 bg-slate-200 rounded col-span-2"></div>
                    <div class="h-2 bg-slate-200 rounded col-span-1"></div>
                </div>
                <div class="h-2 bg-slate-200 rounded"></div>
            </div>
        </div>

    </div>
</div>
</template>

<script>
import {
    defineComponent,
    onMounted
} from "vue";
export default defineComponent({
    props: ['items','class','count'],
})
</script>
