<template>
<div class="grid grid-flow-col justify-center overflow-x-auto pb-10">
    <div class=" px-3 " v-for="item in items" :key="item.code">
        <div class="w-64 max-w-xs overflow-hidden rounded-lg shadow-md bg-white hover:shadow-xl transition-shadow duration-300 ease-in-out " v-bind:class="{'animate-pulse':!item.rates}">
            <div class=" border-b border-gray-200 py-5 px-3 font-medium">
                <p>Daily Foreign Exchange Rates for {{item.label}} ({{item.value}})</p>
            </div>
            <Loader v-if="!item.rates" count="10" />
            <IndividualExchangeResult v-bind:items="item.rates" />
        </div>
    </div>
</div>
</template>

<script>
import {
    MailIcon,
    PhoneIcon
} from '@heroicons/vue/solid'
import Loader from './../common/Loader.vue'
import IndividualExchangeResult from './IndividualExchangeResult.vue'
export default {
    components: {
        Loader,
        MailIcon,
        PhoneIcon,
        IndividualExchangeResult
    },
    props: ['items'],

}
</script>
