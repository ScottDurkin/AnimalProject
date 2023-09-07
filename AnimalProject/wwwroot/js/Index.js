var IndexPage = new Vue({
    el: '#IndexPg',
    data: {
        Dogs: []
    },
    beforeMount() {
        this.OnInit();
    },
    methods: ({
        OnInit: function () {
            var vm = this;
            axios.get(`/api/dog`).then(function (res) {
                var data = res.data;
                vm.Dogs = data;
            });
        },
    })
});