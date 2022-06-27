<template>

<SCHeader/>
<TestComponent/>

</template>

<script>

import SCHeader from '../components/SCHeader.vue';
import TestComponent from '../components/TestComponent.vue';
export default {
    name: "SCTestView",
    data() {
        return {
            scInfo: {},
            bus: {},
            events: {},
            date: {},
            weatherElements: {},
            wx: {},
            t: {},
            pop6h: {}
        };
    },
    async created() {
   
    },
    methods: {
       
    },
    components:{ SCHeader, TestComponent}
};
</script>
