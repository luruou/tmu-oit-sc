<template>
  <template v-for= "item in scinfos" :key="item.scid">
      
      <router-link :to="`/SC/${item.scid}`">{{item.name}}</router-link><br>
  </template>
  <!-- Button trigger modal -->
<button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
  Launch demo modal
</button>

<!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        ...
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>

</template>

<script>

export default {
  name: 'SCList',
  data: () => ({
    scinfos: {}
  }),
  props: {
    msg: String
  },
  async created(){
    this.scinfos = await this.fetchSCList(process.env.VUE_APP_SC_API + '/list')   
  },

  methods: {
    async fetchSCList(url) {
        const promise = this.axios.get(url);
        const dataPromise = await promise.then((response) => response.data);
        return dataPromise;
    }  
  }
}
</script>