<template>
<div class="flex">
    <div class="shadow-lg px-10  mx-auto flex-initial w-full">
        <div class="bg-white px-4 py-5 border-b border-gray-200 sm:px-6">
            <h3 class="text-lg leading-6 font-medium text-gray-900">The fantastic javascript example</h3>
        </div>
        <Alert v-if="tooLong" message="You have now been on the page for half a minute" />
        <div class="bg-white px-4 py-5 sm:px-6">
            <a href="#" :class="{'cursor-not-allowed':!isLoadButtonActive}" class="font-medium text-indigo-600 hover:text-indigo-500 w-full" v-on:click="loadList">Read list to the right</a>
        </div>

        <nav class="relative z-0 inline-flex rounded-md shadow-sm -space-x-px mx-auto">

            <a href="#" class="bg-white border-gray-300 text-gray-500 hover:bg-gray-50 relative inline-flex items-center px-4 py-2 border text-sm font-medium" v-for="item in items" :key="item.id" v-on:click="alertMe(item)"> {{item}} </a>
        </nav>

        <Clock v-bind:time="timeNow" />
        <Modal v-bind:message="numValue" v-bind:open="isOpen" @onClose="onClose" />
    </div>
</div>
</template>

<script lang="js">
import Alert from '../components/Alert.vue'
import Modal from '../components/Modal.vue'
import Clock from '../components/Clock.vue'
import intToEnglish from '../common/intToEnglish.js'

import {
    defineComponent,
    onMounted
} from "vue";
export default defineComponent({
    components: {
        Clock,
        Alert,
        Modal
    },
    props: {

    },
    data: function () {
        return {
            items: [],
            tooLong: false,
            timeNow: new Date(),
            numValue: "",
            isOpen: false,
            isLoadButtonActive: true,
        }
    },
    mounted() {
        setTimeout(() => {
            this.tooLong = true;
        }, 30000);
        setInterval(() => {
            this.timeNow = new Date();
        }, 1000);
    },
    methods: {
        onClose() {
            this.isOpen = false;
        },
        alertMe: function (x) {
            this.isOpen = true;
            this.numValue = intToEnglish(x);
        },
        loadList: function () {
            const items = [];
            for (let i = 0; i < 10; i++) {
                items.push(i);
            }
            this.isLoadButtonActive = false;
            this.items = items;
        },
    },
});
</script>
