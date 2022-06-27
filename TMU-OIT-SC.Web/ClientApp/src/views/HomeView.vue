<template>
  <!-- <SCList /> -->

  <SCHeader />

  <!-- 版本：上下 -->
  <section class="board py-3 bg-primary bg-opacity-35 mb-5">
    <div class="container-fluid">
      <div class="row row-cols-2 justify-content-aroound align-items-center py-4">
        <div class="col-lg-5 py-3 mx-auto text-break" style="width: 437px">
          <!-- <h5 class="text-grey">版本：上下</h5> -->
          <h1 class="fw-bolder room-title">杏春樓電腦教室A</h1>
          <span class="h5 round p-2 px-3 rounded-pill bg-teal-500 text-white">本教室禁止飲食</span>
        </div>
        <div id="tmu-env-content" class="col-lg-5 py-3 bg-white rounded-15 rounded me-6">
          <div class="row px-3">
            <div class="col-8 d-flex flex-column text-dark lh-lg">
              <span>台北市信義區</span>
              <span>多雲時陰短暫陣雨或雷雨</span>
              <p class="text-dark">
                <i class="bi bi-thermometer"></i>
                23°C
                <i class="bi bi-droplet-fill"></i>
                88%
              </p>
            </div>
            <div class="col-3">
              <img src="../assets/icons/thunder-rain.gif" class="mx-auto d-block" width="120" />
            </div>
          </div>

          <!-- 營繕組環境data -->
          <div class="row mt-3 g-0">
            <div id="carousel-tmu" class="carousel slide" data-bs-ride="carousel">
              <div class="carousel-inner">
                <div class="carousel-item active" data-bs-interval="10000">
                  <div class="d-flex flex-row">
                    <div class="col px-4">
                      <span class="text-dark">室內溫度<i class="bi bi-thermometer"></i></span>
                      <h1 class="text-primary tmu-env-data py-0">
                        23.1<span class="fs-3">°C</span>
                      </h1>
                    </div>
                    <div class="col px-4">
                      <span class="text-dark">室內濕度<i class="bi bi-droplet-fill"></i></span>
                      <h1 class="text-primary tmu-env-data">
                        88<span class="fs-3">%</span>
                      </h1>
                    </div>
                  </div>
                </div>
                <div class="carousel-item" data-bs-interval="10000">
                  <div class="d-flex flex-row">
                    <div class="col px-4">
                      <span class="text-dark">二氧化碳(ppm)</span>
                      <h1 class="text-primary tmu-env-data py-0">1000</h1>
                    </div>
                    <div class="col px-4">
                      <span class="text-dark">累積降雨量(mm)</span>
                      <h1 class="text-primary tmu-env-data">631</h1>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <!-- <div class="col px-4">
              <span class="text-dark"
                >室內溫度<i class="bi bi-thermometer"></i
              ></span>
              <h1 class="text-primary room-title py-0">
                23.1<span class="fs-3">°C</span>
              </h1>
            </div>
            <div class="col px-4">
              <span class="text-dark"
                >室內濕度<i class="bi bi-droplet-fill"></i
              ></span>
              <h1 class="text-primary room-title">
                88<span class="fs-3">%</span>
              </h1>
            </div> -->
            <!-- <div class="col px-4">
              <span class="text-dark">二氧化碳(ppm)</span>
              <h1 class="text-primary room-title py-0">1000</h1>
            </div>
            <div class="col px-4">
              <span class="text-dark">累積降雨量(mm)</span>
              <h1 class="text-primary room-title">631</h1>
            </div> -->
          </div>
        </div>
      </div>
    </div>
  </section>

  <!-- <section class="board py-3 bg-primary bg-opacity-35 mb-5">
    <div class="container-fluid">
      <div
        class="row row-cols-2 justify-content-aroound align-items-center py-4"
      >
        <div class="col-lg-5 py-3 mx-auto text-break" style="width:437px">
          <h5 class="text-grey">原版本-左右</h5>
          <h1 class="fw-bolder room-title">杏春樓電腦教室A</h1>
          <span class="h5 round p-2 px-3 rounded-pill bg-teal-500 text-white">本教室禁止飲食</span>
        </div>
        <div class="col-lg-5 py-3 bg-white rounded-15 me-6 rounded">
          <div class="row row-cols-2 px-3">
            <div class="col px-4 d-flex flex-column">
              <span class="text-dark"
                >教室溫度<i class="bi bi-thermometer"></i
              ></span>
              <span class="text-dark"
                >二氧化碳(PPM)<i class="bi bi-thermometer"></i
              ></span>
              <h1 class="text-primary room-title py-0">23°C</h1>
              <span class="text-dark"
                >教室濕度<i class="bi bi-droplet-fill"></i
              ></span>
              <h1 class="text-primary room-title">88%</h1>
            </div>
            <div class="col d-flex flex-column text-dark">
              <span>台北市信義區</span>
              <p class="text-dark">
                <i class="bi bi-thermometer"></i>
                23°C
                <i class="bi bi-droplet-fill"></i>
                88%
              </p>
              <span>多雲</span>
              <img
                src="../assets/icons/thunder-rain.gif"
                class="mx-auto d-block"
                width="130"
              />
            </div>
          </div>
        </div>
      </div>
    </div>
  </section> -->

  <main>
    <section class="container">
      <div class="row row-cols-1">
        <!-- <div class="col p-4 d-flex flex-column position-static">
            <strong class="d-inline-block mb-2 text-primary">World</strong>
            <h3 class="mb-0">Featured post</h3>
            <div class="mb-1 text-muted">Nov 12</div>
            <p class="card-text mb-auto">
              This is a wider card with supporting text below as a natural
              lead-in to additional content.
            </p>
            <a href="#" class="stretched-link">Continue reading</a>
          </div> -->
        <!-- <div class="col"> -->
        <div class="col p-1 card border-0 bg-teal rounded-15 shadow-sm mb-5">
          <div class="bg-white rounded-15">
            <div class="d-flex flex-row justify-content-between text-center">
              <div class="col h1 py-3 my-0 fw-bold bg-secondary bg-opacity-50 rounded-top-left-15">
                10:10-11:00
              </div>
              <div class="col h1 py-3 my-0 fw-bold rounded-top-right-15" style="background-color: #ffd900">
                上課中
              </div>
            </div>
            <div class="card-body px-4">
              <div class="row row-cols-1">
                <div class="col mb-4">
                  <div class="card-text h4 my-3">課號 00000836</div>
                  <h1 class="card-title">
                    <strong class="mb-2 course-name">看不見的手？新世紀的貨幣難題看不見的手？新世紀的貨幣難題看不見的手？新世紀的貨幣難題</strong>
                  </h1>
                </div>
              </div>
            </div>
            <div class="d-flex flex-row ps-4 pt-2 pb-2 align-items-center">
              <div class="my-avatar-circle">
                <!-- 男師圖：user-m.png；女師圖：user-f.png -->
                <img src="../assets/user-m.png" class="avatar-img rounded mx-auto d-block" />
              </div>
              <div class="p-2 px-4 me-auto">
                <div class="card-text mb-1">任課教師</div>
                <h3 class="fw-bolder">王大明</h3>
              </div>
              <div class="my-avatar-circle">
                <!-- 男師圖：user-m.png；女師圖：user-f.png -->
                <!-- <img
                    src="../assets/user-f.png"
                    class="avatar-img rounded mx-auto d-block"
                  /> -->
                <img id="qr" src="data:image/png;base64,/9j/4AAQSkZJRgABAQEAYABgAAD/4RDaRXhpZgAATU0AKgAAAAgABAE7AAIAAAAFAAAISodpAAQAAAABAAAIUJydAAEAAAAKAAAQyOocAAcAAAgMAAAAPgAAAAAc6gAAAAgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHVzZXIAAAAFkAMAAgAAABQAABCekAQAAgAAABQAABCykpEAAgAAAAMxNQAAkpIAAgAAAAMxNQAA6hwABwAACAwAAAiSAAAAABzqAAAACAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAMjAxODowMToxOSAxNDo0NjozMwAyMDE4OjAxOjE5IDE0OjQ2OjMzAAAAdQBzAGUAcgAAAP/hCxdodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvADw/eHBhY2tldCBiZWdpbj0n77u/JyBpZD0nVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkJz8+DQo8eDp4bXBtZXRhIHhtbG5zOng9ImFkb2JlOm5zOm1ldGEvIj48cmRmOlJERiB4bWxuczpyZGY9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkvMDIvMjItcmRmLXN5bnRheC1ucyMiPjxyZGY6RGVzY3JpcHRpb24gcmRmOmFib3V0PSJ1dWlkOmZhZjViZGQ1LWJhM2QtMTFkYS1hZDMxLWQzM2Q3NTE4MmYxYiIgeG1sbnM6ZGM9Imh0dHA6Ly9wdXJsLm9yZy9kYy9lbGVtZW50cy8xLjEvIi8+PHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9InV1aWQ6ZmFmNWJkZDUtYmEzZC0xMWRhLWFkMzEtZDMzZDc1MTgyZjFiIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iPjx4bXA6Q3JlYXRlRGF0ZT4yMDE4LTAxLTE5VDE0OjQ2OjMzLjE0OTwveG1wOkNyZWF0ZURhdGU+PC9yZGY6RGVzY3JpcHRpb24+PHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9InV1aWQ6ZmFmNWJkZDUtYmEzZC0xMWRhLWFkMzEtZDMzZDc1MTgyZjFiIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iPjxkYzpjcmVhdG9yPjxyZGY6U2VxIHhtbG5zOnJkZj0iaHR0cDovL3d3dy53My5vcmcvMTk5OS8wMi8yMi1yZGYtc3ludGF4LW5zIyI+PHJkZjpsaT51c2VyPC9yZGY6bGk+PC9yZGY6U2VxPg0KCQkJPC9kYzpjcmVhdG9yPjwvcmRmOkRlc2NyaXB0aW9uPjwvcmRmOlJERj48L3g6eG1wbWV0YT4NCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgPD94cGFja2V0IGVuZD0ndyc/Pv/bAEMABwUFBgUEBwYFBggHBwgKEQsK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" class="avatar-img rounded mx-auto d-block" />
              </div>
              <div class="p-2 px-4 me-auto">
                <div class="card-text mb-1">任課教師</div>
                <h3 class="fw-bolder">王大明</h3>
              </div>

              <!-- 簽到按鈕Group  -->
              <div class="p-2 px-4 d-flex flex-row">
                <a href="#" class="sign-button btn border border-3 btn-lg disabled">已簽到 38</a>
                <a href="#" class="sign-button btn btn-primary btn-lg ms-1">簽到</a>
              </div>
              <!-- 簽到按鈕Group 結束  -->
            </div>
            <div class="card-footer border-top rounded-bottom-15 text-muted small px-4 py-3" style="min-height: 60px">
              <!-- <p class="card-text mb-auto">
                  <i class="bi bi-info-circle"></i>很多的話想說只能在這裡說
                </p>
                <p class="card-text mb-auto">
                  <i class="bi bi-info-circle"></i>很多的話想說只能在這裡說
                </p> -->
            </div>
          </div>
        </div>
        <!-- </div> -->
        <!-- </div>
      </div>
    </section> -->

        <!-- <section>
      <div class="container">
        <div class="row row-cols-1 g-3"> -->
        <div class="col p-0">
          <div class="d-flex flex-row rounded-10 shadow mb-44 bg-white">
            <div class="py-4 px-4 bg-secondary bg-opacity-25 d-block">12:00-13:00</div>
            <div class="py-4 px-4 me-auto d-flex flex-column justify-content-start">
              <span class="d-inline-block text-truncate course-name" style="max-width: 500px">這門課程的名字很長江尼羅河</span>
              <span class="d-inline-block text-truncate" style="max-width: 500px">DAHL CHRISTOPH DAVID</span>
            </div>
            <div class="py-4 px-4 align-self-center">
              <a href="#" class="sign-button btn btn-primary btn-lg mb-1">簽到</a>
              <!-- <a href="#" class="sign-button btn border">已簽到 38</a> -->
            </div>
          </div>
          <div class="d-flex flex-row rounded-10 shadow mb-44 bg-white">
            <div class="py-4 px-4 bg-secondary bg-opacity-25 d-block">12:00-13:00</div>
            <div class="py-4 px-4 me-auto d-flex flex-column justify-content-start">
              <span class="d-inline-block text-truncate course-name" style="max-width: 500px">這門課程的名字很長很長很長很長很長很長就像長江尼羅河</span>
              <span class="d-inline-block text-truncate" style="max-width: 500px">DAHL CHRISTOPH DAVID</span>
            </div>
            <div class="py-4 px-4 align-self-center">
              <a href="#" class="sign-button btn btn-red-200 btn-lg mb-1">簽退</a>
              <!-- <a href="#" class="sign-button btn border">已簽到 38</a> -->
            </div>
          </div>
          <div class="d-flex flex-row rounded-10 shadow mb-44 bg-white">
            <div class="py-4 px-4 bg-secondary bg-opacity-25 d-block">12:00-13:00</div>
            <div class="py-4 px-4 me-auto d-flex flex-column justify-content-start" style="max-width: 500px">
              <span class="d-inline-block text-truncate course-name" style="max-width: 500px">這門課程這門課程這門課程這門課程這門課</span>
              <span class="d-inline-block text-truncate" style="max-width: 500px">DAHL CHRISTOPH DAVID</span>
            </div>
            <div class="py-4 px-4 align-self-center">
              <a href="#" class="sign-button btn btn-secondary text-opacity-25 btn-lg mb-1 disabled">即將開始</a>
              <!-- <a href="#" class="sign-button btn border">已簽到 38</a> -->
            </div>
          </div>

          <div class="card border border-0 shadow"></div>
        </div>
      </div>
    </section>
  </main>
  <SCFooter />
</template>


<style scoped>
.container {
  max-width: 960px;
}

/*簽到按鈕*/
.sign-button {
  width: 180px;
  font-weight: bold;
  letter-spacing: 3px;
}

/*
    * Dummy devices (replace them with your own or something else entirely!)
    */

.product-device {
  position: absolute;
  right: 10%;
  bottom: -30%;
  width: 300px;
  height: 540px;
  background-color: #333;
  border-radius: 21px;
  transform: rotate(30deg);
}

.product-device::before {
  position: absolute;
  top: 10%;
  right: 10px;
  bottom: 10%;
  left: 10px;
  content: "";
  background-color: rgba(255, 255, 255, 0.1);
  border-radius: 5px;
}

.product-device-2 {
  top: -25%;
  right: auto;
  bottom: 0;
  left: 5%;
  background-color: #e5e5e5;
}

/*
    * Extra utilities
    */

.flex-equal > * {
  flex: 1;
}

@media (min-width: 768px) {
  .flex-md-equal > * {
    flex: 1;
  }
}
</style>


<script>
// @ is an alias to /src
//import SCList from "@/components/SCList.vue";
import SCHeader from "@/components/SCHeader.vue";
import SCFooter from "@/components/SCFooter.vue";

export default {
  name: "HomeView",
  components: {
    //SCList,
    SCHeader,
    SCFooter,
  },
  created() {},
};
</script>
