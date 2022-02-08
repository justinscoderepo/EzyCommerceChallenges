<template>
<div class="flex w-full">
    <div class="sm:rounded-md   mx-auto">
        <div class="px-4 py-5 bg-white space-y-6 sm:p-6 w-full" v-bind:class="{'animate-pulse':!currencyCodes.length}">
            <div class="grid grid-cols-2 gap-6" v-if="currencyCodes.length">
                <div class="col-span-3 sm:col-span-2 ">
                    <label for="company-website" class="block text-sm font-medium text-gray-700">Currencies </label>
                    <CurrencyMultiSelect v-bind:options="currencyCodes" v-bind:values="selectedCurrencyCodes" v-bind:onChange="onChange" />
                </div>
            </div>
            <Loader v-if="!currencyCodes.length" class="w-96" count="1" />
        </div>
        <!-- <div class="px-4 py-3 text-right sm:px-6">
                    <button type="submit" class="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-green-600 hover:bg-ingreendigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-green-500" v-on:click="loadRatesList">Get Currency Rates</button>
                </div>-->
    </div>
</div>
</template>

<script>
import CurrencyMultiSelect from './CurrencyMultiSelect.vue'
import Loader from './../common/Loader.vue'
export default {
    components: {
        Loader,
        CurrencyMultiSelect,
    },
    props: ['currencyCodes', 'selectedCurrencyCodes', 'onChange'],
    
}
</script>
