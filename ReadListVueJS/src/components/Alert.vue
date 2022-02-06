<!-- This example requires Tailwind CSS v2.0+ -->
<template>
<div class="rounded-md bg-blue-50 p-4 w-96 mx-auto mb-3  mt-3">
    <div class="flex">
        <div class="ml-3 flex-1 md:flex md:justify-between">
            <p class="text-sm text-blue-700">{{message}}</p>
        </div>
    </div>
</div>
</template>

<script>
import {
    InformationCircleIcon
} from '@heroicons/vue/solid'
import {
    defineComponent,
    onMounted
} from "vue";
export default defineComponent({
    components: {
        InformationCircleIcon,
    },
    props: ['message'],
})
</script>
