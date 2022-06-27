<template>
  <!-- <footer class="fixed-bottom bg-secondary"> -->
  <footer class="fixed-bottom pt-4">
    <div class="convenient text-muted mt-auto py-4">
      <div class="container">
        <!--  <p class="float-end mb-1">
                       <a href="#">Back to top</a>
                   </p>
                   <p class="mb-1">
                       Album example is &copy; Bootstrap, but please download and customize it
                       for yourself!
                   </p>
                   <p class="mb-0">
                       New to Bootstrap? <a href="/">Visit the homepage</a> or read our
                       <a href="/docs/5.1/getting-started/introduction/">getting started guide</a>.
                   </p> -->

        <!-- <div class="row row-cols-sm-4 row-cols-md-4 g-5">
        <div class="col">
          <div class="card">
            <button class="btn btn-light btn-lg py-2">
              <i class="bi bi-house-door"></i>
              <span
                class="d-inline-block text-truncation"
                style="max-width: 120px"
                >設備報修設備報修</span
              >
            </button>
          </div>
        </div>
        <div class="col">
          <div class="card">
            <button class="btn btn-light btn-lg">
              <i class="bi bi-house-door"></i>
              設備報修
            </button>
          </div>
        </div>
        <div class="col">
          <div class="card">
            <button class="btn btn-light btn-lg">
              <i class="bi bi-house-door"></i>
              設備報修
            </button>
          </div>
        </div>
        <div class="col">
          <div class="card">
            <button class="btn btn-light btn-lg">
              <i class="bi bi-house-door"></i>
              設備報修
            </button>
          </div>
        </div>

        <div class="col">
          <div class="card shadow-sm">
            <div class="card-body">
              <p class="card-text">
                <i class="bi bi-house-door"></i>
                回首頁
              </p>
              <div class="d-flex justify-content-between align-items-center">
                <div class="btn-group">
                  <button
                    type="button"
                    class="btn btn-sm btn-outline-secondary"
                  >
                    View
                  </button>
                  <button
                    type="button"
                    class="btn btn-sm btn-outline-secondary"
                  >
                    Edit
                  </button>
                </div>
                <small class="text-muted">9 mins</small>
              </div>
            </div>
          </div>
        </div>
      </div> -->

        <div class="d-flex justify-content-evenly">
          <button class="btn bg-light btn-lg rounded-10 py-2 me-auto">
            <!-- <i class="bi bi-house-door align-middle fs-1"></i> -->
            <img src="../assets/icons/home.png" width="36" />
            <span class="d-inline-block text-truncation align-middle" style="max-width: 120px">回首頁</span>
          </button>
          <button class="btn bg-light btn-lg rounded-10 py-2 me-auto">
            <!-- <i class="bi bi-tools"></i> -->
            <img src="../assets/icons/borrowspace.png" width="36" />
            <span class="d-inline-block text-truncation align-middle" style="max-width: 120px">設備報修</span>
          </button>
          <button class="btn bg-light btn-lg rounded-10 py-2 me-auto">
            <!-- <i class="bi bi-house-door"></i> -->
            <img src="../assets/icons/borrowspace.png" width="36" />
            <span class="d-inline-block text-truncation align-middle" style="max-width: 120px">場地借用</span>
          </button>

          <button class="btn bg-light btn-lg rounded-10 py-2">
            <!-- <i class="bi bi-house-door"></i> -->
            <img src="../assets/icons/bus.png" width="36" />
            <span class="d-inline-block text-truncation align-middle" style="max-width: 120px">接駁車</span>
          </button>
        </div>
      </div>
    </div>

    <div class="container py-3">
      <div class="d-flex justify-content-between align-items-center">
        <button class="btn btn-dark rounded-pill">ENGLISH</button>
        <p class="float-end mb-1 small">更新日期：2022/05/10</p>
      </div>
    </div>
  </footer>
</template>

<style scoped>
footer {
  background-image: url("../assets/footer.png");
  background-repeat: no-repeat;
  /* background-size:cover; */
  background-position: bottom;
}
</style>

<script>
export default {
  name: "SCFooter",
};
</script>