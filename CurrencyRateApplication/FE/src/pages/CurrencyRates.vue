<template>
<div class="md:grid md:grid-cols-1 md:gap-x-2">
    <div class="shadow-lg px-10  mx-auto col-span-2">
        <CurrencyRateHeader />
        <CurrencyRateFilter v-bind:currencyCodes="currencyCodes" v-bind:selectedCurrencyCodes="selectedCurrencyCodes" v-bind:onChange="onChangeFilter" />
    </div>
</div>
<div class="drop-shadow-md px-10 col-span-2 mt-10 mb-10">
    <CurrencyExchangeResults v-bind:items="currencyRatesResponseList" />
</div>
</template>

<script lang="js">
import CurrencyRateHeader from '../components/currency/CurrencyRateHeader.vue'
import CurrencyRateFilter from '../components/currency/CurrencyRateFilter.vue'
import CurrencyExchangeResults from '../components/currency/CurrencyExchangeResults.vue'
import axios from 'axios'
import {
    get
} from '../services/http.js'

export default {
    components: {
        CurrencyRateHeader,
        CurrencyRateFilter,
        CurrencyExchangeResults,
    },
    data: function () {
        return {
            currencyCodes: [],
            currencyRatesResponseList: [],
            selectedCurrencyCodes: ["USD"],
            onChangeFilter: (values) => {
                this.selectedCurrencyCodes = values;
                this.mapCodeToList();
                this.loadRatesList();
                this.scrollToLast();
            },
        }
    },
    async mounted() {
        let response = await get('currency-codes');
        this.selectedCurrencyCodes = ["USD", "EUR"]
        this.currencyCodes = response.map(x => {
            return {
                label: x.name,
                value: x.code,
            }
        });
        this.currencyCodes.unshift({
            label: 'U.S. Dollar',
            value: 'USD',
        })
        this.mapCodeToList();
        this.loadRatesList();
    },
    methods: {
        scrollToLast: function () {
            setTimeout(() => {
                let element = document.querySelector('.overflow-x-auto');
                element.scrollTo({
                    left: element.scrollWidth,
                    behavior: "smooth"
                });
            }, 500);
        },
        mapCodeToList: function () {
            this.currencyRatesResponseList = this.selectedCurrencyCodes.map(x => {
                let y = this.currencyCodes.find(z => z.value == x);
                let z = this.currencyRatesResponseList.find(z => z.value == x);
                return {
                    ...y,
                    ...z
                };
            });
        },
        loadRatesList: function () {
            this.selectedCurrencyCodes.forEach(x => {
                let y = this.currencyRatesResponseList.find(z => z.value == x);
                if (!y.rates) {
                    let request = get(`currency-rates/${y.value.toLowerCase()}`);
                    request.then((res) => {
                        y.rates = res;
                    })
                }
            });
        },
    },
};
</script>
