<template>
<ul role="list" class="divide-y divide-gray-200">
    <li v-for="item in items" :key="item.currencyCode" class="relative bg-white py-3 px-4 hover:bg-gray-50 focus-within:ring-2 focus-within:ring-inset focus-within:ring-indigo-600">
        <div class="flex justify-between space-x-3">
            <div class="min-w-0 flex-1">
                <div class="block focus:outline-none" :title="`${item.currencyCode} - ${ item.currencyName }`">
                    <p class="text-sm text-gray-900  text-left truncate" ><span class="text-red-800 font-medium ">{{ item.currencyCode }}</span> - {{ item.currencyName }}</p>
                 
                </div>
            </div>
            <span class="flex-shrink-0 whitespace-nowrap text-sm text-purple-800 font-medium" :title="`Exchance Rate is ${item.exchangeRate }`" >{{item.exchangeRate}}</span>
        </div>
        <div class="mt-1">
             <p class="text-sm text-gray-500 truncate text-left">Inverse Rate: {{ item.inverseRate }}</p>
        </div>
    </li>
</ul>
</template>

<script>
export default {
    components: {},
    props: ['items'],
}
</script>
