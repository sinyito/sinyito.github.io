* {
  box-sizing: border-box;
}

body, html {
  margin: 0px;
  padding: 0px;
  font-family: "Noto Sans TC", "Roboto", sans-serif;
  line-height: 1.5;
}

.page {
  width: 100%;
  overflow: hidden;
  margin: 0px;
  padding: 0px;
}

section {
  min-height: 600px;
  width: 100%;
  background-color: white;
  border-bottom: 1px solid #f0f0f0;
}
section .section-header {
  display: block;
  width: 200px;
  float: left;
}
section .section-header h2 {
  font-size: 32px;
  margin-bottom: 0em;
  margin-block-start: 0em;
  margin-block-end: 0em;
}

#kv {
  width: 100%;
  height: 100vh;
  background: #1e9494;
  /*Mouse wheel*/
}
#kv .navbar-collapse {
  justify-content: flex-end;
}
#kv .nav-link {
  color: #fff;
}
#kv .navbar-brand {
  display: block;
  width: 180px;
  height: 37px;
  overflow: hidden;
  text-indent: -999px;
  float: left;
  background: url(/images/logo@2x.png) no-repeat left top;
  background-size: 180px;
}
#kv .title {
  display: flex;
  height: 80%;
  align-items: center;
  text-align: center;
}
#kv .title .logogif {
  width: 90px;
  margin-bottom: 30px;
}
#kv .mouse-wrap {
  position: absolute;
  top: 85%;
  left: 50%;
  transform: translate(-50%, -50%);
}
#kv .mouse-wrap .mouse {
  position: absolute;
  top: 0;
  left: 50%;
  width: 24px;
  transform: translateX(-50%);
  animation: nudgeMouse 5.5s ease-out infinite;
}
#kv .mouse-wrap .mouse .frame {
  position: absolute;
  z-index: 1;
  width: 100%;
}
#kv .mouse-wrap .mouse .frame path {
  fill: none;
  stroke: #fff;
  stroke-width: 3;
  opacity: 0.5;
}
#kv .mouse-wrap .mouse .Animate-Draw {
  fill: none;
  stroke: #fff;
  stroke-width: 3;
  fill-opacity: 1;
}
#kv .mouse-wrap .mouse .mouse-left,
#kv .mouse-wrap .mouse .mouse-right {
  position: absolute;
  z-index: 2;
  width: 50%;
}
#kv .mouse-wrap .mouse .mouse-left .Animate-Draw {
  animation: DrawLine 5.5s ease-out infinite;
}
#kv .mouse-wrap .mouse .mouse-right {
  right: 0;
}
#kv .mouse-wrap .mouse .mouse-right .Animate-Draw {
  animation: DrawLineBack 5.5s ease-out infinite;
}
#kv .mouse-wrap .mouse:after {
  content: "";
  position: absolute;
  top: -12px;
  left: 55%;
  margin-left: -3px;
  background-color: #fff;
  width: 4px;
  height: 6px;
  border-radius: 3px;
  transform: translateY(20px);
  animation: trackBallSlide 5.5s linear infinite;
}
@-moz-keyframes DrawLine {
  0% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  22% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38% {
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  48% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64% {
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  74% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  90% {
    stroke-opacity: 1;
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
  }
  90.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
}
@-webkit-keyframes DrawLine {
  0% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  22% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38% {
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  48% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64% {
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  74% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  90% {
    stroke-opacity: 1;
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
  }
  90.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
}
@-o-keyframes DrawLine {
  0% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  22% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38% {
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  48% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64% {
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  74% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  90% {
    stroke-opacity: 1;
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
  }
  90.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
}
@keyframes DrawLine {
  0% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  22% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38% {
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  48% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64% {
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  74% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  90% {
    stroke-opacity: 1;
    stroke-dashoffset: 125;
    stroke-dasharray: 120;
  }
  90.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
}
@-moz-keyframes DrawLineBack {
  0% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  22% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38% {
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  48% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64% {
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  74% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  90% {
    stroke-opacity: 1;
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
  }
  90.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
}
@-webkit-keyframes DrawLineBack {
  0% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  22% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38% {
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  48% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64% {
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  74% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  90% {
    stroke-opacity: 1;
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
  }
  90.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
}
@-o-keyframes DrawLineBack {
  0% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  22% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38% {
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  48% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64% {
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  74% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  90% {
    stroke-opacity: 1;
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
  }
  90.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
}
@keyframes DrawLineBack {
  0% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  22% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38% {
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  38.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  48% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64% {
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  64.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
  74% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 1;
  }
  90% {
    stroke-opacity: 1;
    stroke-dashoffset: -114;
    stroke-dasharray: 120;
  }
  90.1% {
    stroke-dashoffset: 0;
    stroke-dasharray: 120;
    stroke-opacity: 0;
  }
}
@-moz-keyframes nudgeMouse {
  0% {
    transform: translate(-50%, 0);
  }
  22% {
    transform: translate(-50%, 0);
  }
  38% {
    transform: translate(-50%, 9px);
  }
  48% {
    transform: translate(-50%, 0);
  }
  64% {
    transform: translate(-50%, 9px);
  }
  74% {
    transform: translate(-50%, 0);
  }
  90% {
    transform: translate(-50%, 9px);
  }
}
@-webkit-keyframes nudgeMouse {
  0% {
    transform: translate(-50%, 0);
  }
  22% {
    transform: translate(-50%, 0);
  }
  38% {
    transform: translate(-50%, 9px);
  }
  48% {
    transform: translate(-50%, 0);
  }
  64% {
    transform: translate(-50%, 9px);
  }
  74% {
    transform: translate(-50%, 0);
  }
  90% {
    transform: translate(-50%, 9px);
  }
}
@-o-keyframes nudgeMouse {
  0% {
    transform: translate(-50%, 0);
  }
  22% {
    transform: translate(-50%, 0);
  }
  38% {
    transform: translate(-50%, 9px);
  }
  48% {
    transform: translate(-50%, 0);
  }
  64% {
    transform: translate(-50%, 9px);
  }
  74% {
    transform: translate(-50%, 0);
  }
  90% {
    transform: translate(-50%, 9px);
  }
}
@keyframes nudgeMouse {
  0% {
    transform: translate(-50%, 0);
  }
  22% {
    transform: translate(-50%, 0);
  }
  38% {
    transform: translate(-50%, 9px);
  }
  48% {
    transform: translate(-50%, 0);
  }
  64% {
    transform: translate(-50%, 9px);
  }
  74% {
    transform: translate(-50%, 0);
  }
  90% {
    transform: translate(-50%, 9px);
  }
}
@-moz-keyframes trackBallSlide {
  0% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  22% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  26% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  34% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  41% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  48% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  52% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  60% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  67% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  74% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  78% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  86% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  93% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  100% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
}
@-webkit-keyframes trackBallSlide {
  0% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  22% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  26% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  34% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  41% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  48% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  52% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  60% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  67% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  74% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  78% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  86% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  93% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  100% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
}
@-o-keyframes trackBallSlide {
  0% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  22% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  26% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  34% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  41% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  48% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  52% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  60% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  67% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  74% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  78% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  86% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  93% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  100% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
}
@keyframes trackBallSlide {
  0% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  22% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  26% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  34% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  41% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  48% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  52% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  60% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  67% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  74% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
  78% {
    transform: translateY(30px) scale(0.9);
    opacity: 1;
  }
  86% {
    transform: translateY(55px) scale(0.1);
    opacity: 0;
  }
  93% {
    transform: translateY(30px) scale(0);
    opacity: 0.3;
  }
  100% {
    transform: translateY(20px) scale(1);
    opacity: 1;
  }
}

@media screen and (max-width: 500px) {
  #kv .navbar-brand {
    display: block;
    width: 124px;
    height: 20px;
    overflow: hidden;
    text-indent: -999px;
    float: left;
    background: url(/images/logo@2x.png) no-repeat left top;
    background-size: 124px;
  }
}
#solgan {
  width: 100%;
  height: 80vh;
  background-image: linear-gradient(to bottom, #2dbbde, #08cb88 30%, #00bc92 90%);
  position: relative;
  padding-top: 100px;
}
#solgan .digital {
  width: 400px;
  margin-bottom: 70px;
}
#solgan .newlife {
  height: 700px;
}

#about {
  width: 100%;
  background-image: linear-gradient(to bottom, #00bc92, #00bc92 90%);
  padding: 60px 0 80px 0;
  position: relative;
}
#about .about-world {
  display: block;
  width: 700px;
  z-index: -1;
  margin: 0 auto;
}
#about .about-title {
  font-size: 32px;
  color: #fff;
  font-weight: bold;
  width: 70%;
  text-align: center;
  margin: 0 auto;
  margin-top: -30px;
  margin-bottom: 60px;
}
#about .about-talk {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  margin-bottom: 10px;
}
#about .about-talk p {
  color: #fff;
  font-size: 20px;
  margin: 0px 20px;
  text-align: center;
}
#about .about-name {
  text-align: center;
  color: #fff;
  font-size: 16px;
}
#about .about-content {
  font-size: 16px;
  color: #fff;
  margin-top: 40px;
}
#about .number-out {
  display: flex;
  flex-direction: column;
}
#about .number-out .number {
  display: flex;
  text-align: center;
  color: #fff;
  font-size: 16px;
  align-items: center;
  justify-content: center;
}
#about .number-out .number .count {
  font-size: 32px;
  padding-right: 10px;
}
#about .number-out .count-p {
  font-size: 18px;
  color: #fff;
  text-align: center;
}
#about .boss-img {
  display: block;
  width: 100%;
  height: auto;
  margin: 0 auto;
}
#about .ToMovie {
  width: 100%;
  height: 590px;
  border-radius: 20px;
  z-index: 1;
}

#about:before {
  content: "";
  width: 100%;
  height: 400px;
  background: #fff;
  position: absolute;
  bottom: 0;
  left: 0;
}

@media screen and (max-width: 500px) {
  #about .about-world {
    display: block;
    width: 90%;
    margin: 0 auto;
  }

  .count {
    font-size: 20px;
    padding-right: 10px;
  }

  #about .boss-img {
    display: block;
    width: 90%;
    margin: 0 auto;
  }
}
#article {
  padding-top: 30px;
  padding-bottom: 30px;
  background-image: url(../images/life@2x.png), url(../images/circle.png);
  background-repeat: no-repeat, no-repeat;
  background-position: top left, -90px 500px;
  background-size: 280px auto, 180px 180px;
  background-attachment: fixed;
}
#article .section-header {
  width: calc(100% - 600px);
}
@media screen and (max-width: 768px) {
  #article .filter-tab {
    margin-left: auto;
    margin-right: auto;
  }
  #article .section-header {
    width: calc(100% - 0px);
  }
  #article .section-header a.section-link {
    margin-left: 20px;
  }
}
@media screen and (min-width: 769px) and (max-width: 992px) {
  #article .section-header {
    width: 200px;
  }
  #article .section-header a.section-link {
    margin-left: 20px;
  }
}
#article .section-header a.section-link,
#article .section-header a.section-link:link,
#article .section-header a.section-link:hover,
#article .section-header a.section-link:focus,
#article .section-header a.section-link:visited {
  background-color: rgba(255, 255, 255, 0);
  display: block;
  text-decoration: none;
  color: inherit;
}
#article .section-header a.section-link h2 {
  height: 46px;
  display: block;
  float: left;
}
#article .section-header a.section-link:after {
  content: "";
  width: 30px;
  height: 30px;
  display: block;
  background-image: url(../images/btn-icon-ttitle-arrow@2x.png);
  background-size: cover;
  background-repeat: no-repeat;
  float: left;
  margin-top: 6px;
  margin-left: 5px;
  transition: margin-left 0.3s ease-in-out;
}
#article .section-header a.section-link:hover:after {
  margin-left: 10px;
}

.filter-tab span.tabitemmark {
  background-color: #ff4d2d;
  width: calc(25% - 18px);
  height: 2px;
  display: block;
  margin-top: 38px;
  transition: all 0.6s ease-in-out;
}

ul#article-flters {
  float: right;
  display: -webkit-flex;
  -webkit-flex-direction: row;
  display: flex;
  flex-direction: row;
  list-style-type: none;
  margin-block-start: 0em;
  margin-block-end: 0em;
  margin-inline-start: 0px;
  margin-inline-end: 0px;
  padding-inline-start: 0px;
}
ul#article-flters li {
  list-style-type: none;
  display: block;
  background-color: rgba(231, 229, 229, 0);
  margin-right: 10px;
  margin-left: 10px;
  padding: 12px;
  color: #8b8b8b;
  cursor: pointer;
}
ul#article-flters li:hover {
  color: rgba(139, 139, 139, 0.8);
}
ul#article-flters li.filter-active {
  color: #ff4d2d;
}

.article-container {
  padding-top: 30px;
  z-index: 3;
  position: relative;
}

.article-item {
  display: block;
  background-color: #fefefe00;
  min-height: 200px;
  padding-top: 10px;
  padding-bottom: 10px;
  padding-left: 15px;
  padding-right: 15px;
  transition: all 0.6s ease-in-out;
}
.article-item.show {
  display: block;
}
.article-item.hidden {
  display: none;
}
.article-item .card {
  border: rgba(255, 255, 255, 0) solid 1px;
  padding: 20px;
  background-color: white;
}
.article-item img {
  border-radius: 6px;
}
.article-item .article-info {
  padding: 10px 0px 0px 0px;
}
.article-item .article-info .datetime {
  font-size: 14px;
  color: #404040;
}
.article-item .article-info .title {
  font-size: 16px;
  font-weight: bold;
  padding: 10px 0px 10px 0px;
  text-overflow: ellipsis;
  display: inline-block;
  width: 100%;
  box-sizing: border-box;
  color: #111111;
}
.article-item .article-info .des {
  width: 100%;
  font-size: 12px;
  color: #404040;
}

#doc {
  padding-top: 30px;
  padding-bottom: 30px;
  background-image: url(../images/f3.jpg), linear-gradient(to right, rgba(255, 255, 255, 0) 0%, rgba(255, 255, 255, 0) 100%);
  background-repeat: no-repeat, no-repeat;
  background-position: top left, top right;
  background-size: calc(30% + 50px) 800px, 100% auto;
  background-attachment: fixed;
}
#doc:after {
  content: "";
  width: 600px;
  height: 177px;
  background-image: url(../images/project.png), linear-gradient(to right, rgba(255, 255, 255, 0) 0%, rgba(255, 255, 255, 0) 100%);
  background-repeat: no-repeat;
  background-size: cover;
  background-position: left top;
  position: fixed;
  right: 0px;
  z-index: -1;
  top: 20px;
  display: block;
  opacity: 0;
  transition: opacity 1s ease-in-out;
}
#doc.showbg:after {
  content: "";
  width: 600px;
  height: 177px;
  background-image: url(../images/project.png), linear-gradient(to right, rgba(255, 255, 255, 0) 0%, rgba(255, 255, 255, 0) 100%);
  background-repeat: no-repeat;
  background-size: cover;
  background-position: left top;
  position: fixed;
  right: 0px;
  z-index: 1;
  top: 20px;
  display: block;
  opacity: 0.8;
}
#doc .container {
  position: relative;
  z-index: 3;
}
#doc .section-header {
  width: calc(100% - 600px);
}
@media screen and (max-width: 768px) {
  #doc .section-header {
    width: calc(100% - 0px);
  }
  #doc .section-header a.section-link {
    margin-left: 20px;
  }
}
@media screen and (min-width: 769px) and (max-width: 992px) {
  #doc .section-header {
    width: 200px;
  }
  #doc .section-header a.section-link {
    margin-left: 20px;
  }
}
#doc .section-header a.section-link,
#doc .section-header a.section-link:link,
#doc .section-header a.section-link:hover,
#doc .section-header a.section-link:focus,
#doc .section-header a.section-link:visited {
  background-color: rgba(255, 255, 255, 0);
  display: block;
  text-decoration: none;
  color: inherit;
}
#doc .section-header a.section-link h2 {
  height: 46px;
  display: block;
  float: left;
}
#doc .section-header a.section-link:after {
  content: "";
  width: 30px;
  height: 30px;
  display: block;
  background-image: url(../images/btn-icon-ttitle-arrow@2x.png);
  background-size: cover;
  background-repeat: no-repeat;
  float: left;
  margin-top: 6px;
  margin-left: 5px;
  transition: margin-left 0.3s ease-in-out;
}
#doc .section-header a.section-link:hover:after {
  margin-left: 10px;
}
#doc #doc-container {
  margin-top: 30px;
}
#doc .last-doc-item-link,
#doc .last-doc-item-link:link,
#doc .last-doc-item-link:hover,
#doc .last-doc-item-link:focus,
#doc .last-doc-item-link:visited {
  background-color: rgba(255, 255, 255, 0);
  display: block;
  text-decoration: none;
  color: inherit;
}
#doc .last-doc-item {
  display: block;
  height: 200px;
  background-image: url(../images/doc-img.png), linear-gradient(to right, white 0%, white 100%);
  background-repeat: no-repeat, no-repeat;
  background-position: bottom left, top right;
  background-size: 185px 94px, 100% auto;
  margin: 10px;
  box-shadow: 3px 6px 11px 0 rgba(218, 218, 218, 0.52);
  padding: 20px;
  text-align: center;
  transition: margin-left 0.8s ease-in-out;
}
#doc .last-doc-item:hover {
  border: 1px solid #ff4d2d;
}
#doc .last-doc-item .wrap {
  width: calc(100% - 0px);
  margin-top: 30px;
}
#doc .last-doc-item .wrap .title {
  width: calc(100% - 0px);
  font-size: 20px;
  font-weight: bold;
  line-height: 1.2;
  color: rgba(17, 17, 17, 0.8);
}
#doc .last-doc-item .wrap .datetime {
  font-size: 14px;
  color: #8b8b8b;
  margin-top: 10px;
}
#doc .last-doc-item .wrap:after {
  content: "";
  width: 30px;
  height: 30px;
  display: block;
  background-color: #ff4d2d;
  border-radius: 50%;
  background-image: url(../images/btn-line-circle-btn.svg);
  background-size: 30px 30px;
  background-repeat: no-repeat;
  background-position: 0px 0px;
  float: left;
  margin-top: 10px;
  margin-left: calc(50% - 15px);
  animation: arrowmove 0.5s ease-in-out infinite;
}
#doc .last-doc-item .wrap:hover .title {
  color: #111111;
}
#doc a.last-doc-item-link:hover .last-doc-item .wrap:after {
  animation-play-state: paused;
}
#doc ul.doclist {
  list-style-type: none;
  margin-block-start: 0em;
  margin-block-end: 0em;
  margin-inline-start: 0px;
  margin-inline-end: 0px;
  padding-inline-start: 0px;
  margin-top: 10px;
}
#doc ul.doclist li {
  list-style-type: none;
  display: block;
  border-bottom: 1px solid #d3d3d3;
  height: 68px;
  background-color: #ffffff;
  transition: all 0.3s ease-in-out;
}
#doc ul.doclist li .datetime {
  font-size: 14px;
  color: #8b8b8b;
  padding-left: 10px;
  display: block;
  float: left;
  width: 100px;
  padding-top: 18px;
  line-height: 50px;
  margin-right: 30px;
}
#doc ul.doclist li .title {
  font-size: 16px;
  color: #111111;
  display: block;
  float: left;
  width: calc(100% - 131px);
  padding-top: 18px;
  line-height: 50px;
}
#doc ul.doclist li:after {
  content: "";
  width: 30px;
  height: 30px;
  display: block;
  background-image: url(../images/btn-icon-arrow-gray.svg);
  background-size: cover;
  background-repeat: no-repeat;
  background-position: 0px 0px;
  float: right;
  position: relative;
  margin-top: -38px;
  margin-left: 0px;
  right: 10px;
}
#doc ul.doclist li:hover {
  background-color: #ebfdf5;
  box-shadow: 2px 2px 6px 0 rgba(158, 158, 158, 0.247);
  transform: scale(1.02);
}
#doc ul.doclist li:hover .title {
  font-weight: bold;
}
#doc ul.doclist li:hover:after {
  content: "";
  width: 30px;
  height: 30px;
  display: block;
  background-image: url(../images/btn-icon-arrow-red.svg);
  background-size: cover;
  background-repeat: no-repeat;
  background-position: 0px 0px;
  float: right;
  position: relative;
  margin-top: -38px;
  margin-left: 0px;
  right: 10px;
}

@media screen and (min-width: 1200px) {
  #doc {
    background-image: url(../images/f3.jpg), linear-gradient(to right, rgba(255, 255, 255, 0.1) 0%, rgba(255, 255, 255, 0) 100%);
    background-repeat: no-repeat, no-repeat;
    background-position: top left, top right;
    background-size: calc(28% + 30px) 800px, 100% auto;
    background-attachment: fixed;
  }
}
@media screen and (min-width: 992px) and (max-width: 1199px) {
  #doc {
    background-image: url(../images/f3.jpg), linear-gradient(to right, rgba(255, 255, 255, 0.1) 0%, rgba(255, 255, 255, 0) 100%);
    background-repeat: no-repeat, no-repeat;
    background-position: top left, top right;
    background-size: calc(26% + 30px) 800px, 100% auto;
    background-attachment: fixed;
  }
}
@media screen and (min-width: 768px) and (max-width: 991px) {
  #doc {
    background-image: url(../images/f3.jpg), linear-gradient(to right, rgba(255, 255, 255, 0.1) 0%, rgba(255, 255, 255, 0) 100%);
    background-repeat: no-repeat, no-repeat;
    background-position: top left, top right;
    background-size: calc(25% + 30px) 800px, 100% auto;
    background-attachment: fixed;
  }
}
@media screen and (max-width: 767px) {
  #doc {
    background-image: url(../images/f3.jpg), linear-gradient(to right, rgba(255, 255, 255, 0.1) 0%, rgba(255, 255, 255, 0) 100%);
    background-repeat: no-repeat, no-repeat;
    background-position: top left, top right;
    background-size: calc(100% + 0px) 200px, 100% auto;
    background-attachment: fixed;
  }
}
@keyframes arrowmove {
  0% {
    background-position: 0px 0px;
  }
  80% {
    background-position: 3px 0px;
  }
  100% {
    background-position: 0px 0px;
  }
}
section#joinus {
  min-height: 300px;
}
section#joinus .join-container {
  padding: 80px 20px 60px 20px;
}
section#joinus .imagewrap {
  background-color: #efefef00;
  width: 560px;
  height: 400px;
  overflow: hidden;
  margin-top: -401px;
  right: 0px;
  position: relative;
  margin-left: calc(100% - 421px);
}
section#joinus .imagewrap.fadeup:before {
  content: "";
  width: 386px;
  height: 316px;
  display: block;
  position: relative;
  background-image: url(../images/joinus-img.png);
  background-repeat: no-repeat;
  background-size: cover;
  z-index: 999;
  position: absolute;
  margin-top: 84px;
  margin-right: 1px;
  right: 38px;
  opacity: 0;
  animation: fadeup1 0.6s ease-in-out 0.8s forwards;
}
section#joinus .imagewrap img.circle {
  width: 320px;
  height: 320px;
  display: none;
  margin-top: 108px;
  opacity: 0;
}
section#joinus .imagewrap.fadeup img.circle {
  width: 320px;
  height: 320px;
  display: block;
  margin-top: 108px;
  opacity: 0;
  animation: fadeup2 0.8s ease-in-out 0.5s forwards;
}
@keyframes rotate {
  0% {
    transform: rotate(0deg);
  }
  50% {
    transform: rotate(180deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
@keyframes fadeup1 {
  0% {
    opacity: 0;
    margin-top: 200px;
  }
  50% {
    opacity: 0.8;
    margin-top: 80px;
  }
  100% {
    opacity: 1;
    margin-top: 84px;
  }
}
@keyframes fadeup2 {
  0% {
    opacity: 0;
    margin-top: 200px;
  }
  50% {
    opacity: 0.8;
    margin-top: 130px;
  }
  100% {
    opacity: 1;
    margin-top: 108px;
  }
}
section#joinus .outsidewrap {
  display: block;
  height: 240px;
  width: 100%;
  background-image: linear-gradient(to right, #4ed497 0%, #44a8f2 100%);
  padding: 1px;
}
section#joinus .insidewrap {
  display: block;
  background-color: #ffffff;
  height: 238px;
  overflow: hidden;
}
section#joinus .insidewrap img.title {
  position: absolute;
  margin-top: -30px;
  display: block;
  width: 240px;
  height: 50px;
  margin-left: calc(10% - 10px);
}
section#joinus .insidewrap .content-wrap {
  margin-top: 50px;
  width: calc(100% - 500px);
  display: block;
  margin-left: 30px;
  text-align: center;
  font-size: 16px;
  /* GENERAL BUTTON STYLING */
  /* BUTTON secondary */
  /* BUTTON primary */
}
section#joinus .insidewrap .content-wrap p {
  font-size: 16px;
  font-stretch: normal;
  font-style: normal;
  line-height: 1.5;
  letter-spacing: normal;
  text-align: center;
  margin-bottom: 8px;
}
section#joinus .insidewrap .content-wrap p.strong {
  background-image: linear-gradient(93deg, #4ed497 2%, #44a8f2 100%);
  font-size: 16px;
  font-weight: bold;
  -webkit-background-clip: text;
  background-clip: text;
  -webkit-text-fill-color: transparent;
}
section#joinus .insidewrap .content-wrap button,
section#joinus .insidewrap .content-wrap button::after {
  -webkit-transition: all 0.3s;
  -moz-transition: all 0.3s;
  -o-transition: all 0.3s;
  transition: all 0.3s;
}
section#joinus .insidewrap .content-wrap button {
  min-width: 160px;
  min-height: 40px;
  padding: 12px 24px;
  border-radius: 40px;
  font-size: 16px;
  line-height: 1.5;
  font-weight: bold;
  margin-left: auto;
  margin-right: auto;
  margin-top: 40px;
}
section#joinus .insidewrap .content-wrap .secondary {
  background: none;
  border: solid 1px #ff6b50;
  display: block;
  position: relative;
}
section#joinus .insidewrap .content-wrap .secondary span {
  color: #ff6b50;
  z-index: 999;
  position: relative;
}
section#joinus .insidewrap .content-wrap .secondary::after {
  background: linear-gradient(90deg, #ff6b50, #f03120);
  content: "";
  position: absolute;
  display: block;
}
section#joinus .insidewrap .content-wrap .secondary:hover span {
  color: #ffffff;
  z-index: 999;
  position: relative;
}
section#joinus .insidewrap .content-wrap .secondary::after {
  left: 50%;
  top: 20%;
  width: 0;
  height: 50%;
  opacity: 0;
}
section#joinus .insidewrap .content-wrap .secondary:hover:after {
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  border-radius: 40px;
  opacity: 1;
}
section#joinus .insidewrap .content-wrap .primary {
  background: #ff6b50;
  border: solid 1px #ff6b50;
  color: #fff;
  display: block;
  position: relative;
}
section#joinus .insidewrap .content-wrap .primary span {
  color: #ffffff;
  z-index: 999;
  position: relative;
}
section#joinus .insidewrap .content-wrap .primary::after {
  background: linear-gradient(90deg, #ff6b50, #f03120);
  content: "";
  position: absolute;
  z-index: 1;
}
section#joinus .insidewrap .content-wrap .primary:hover {
  color: #fff;
  background: none;
}
section#joinus .insidewrap .content-wrap .primary:hover span {
  color: #ffffff;
  z-index: 999;
  position: relative;
}
section#joinus .insidewrap .content-wrap .primary::after {
  left: 50%;
  top: 20%;
  width: 0;
  height: 50%;
  opacity: 0;
  color: #fff;
}
section#joinus .insidewrap .content-wrap .primary:hover:after {
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  border-radius: 40px;
  opacity: 1;
}

@media screen and (max-width: 768px) {
  section#joinus .imagewrap {
    background-color: #efefef00;
    width: 560px;
    height: 400px;
    overflow: hidden;
    margin-top: -401px;
    right: 0px;
    position: relative;
    margin-left: calc(100% - 421px);
    display: none;
  }

  section#joinus .insidewrap .content-wrap {
    margin-top: 50px;
    width: calc(100% - 60px);
    display: block;
    margin-left: 30px;
    margin-right: 30px;
    text-align: center;
    font-size: 16px;
  }

  section#joinus .outsidewrap {
    display: block;
    height: 320px;
    width: 100%;
  }

  section#joinus .insidewrap {
    height: 318px;
  }
}
@media screen and (min-width: 769px) and (max-width: 992px) {
  section#joinus .imagewrap {
    background-color: #efefef00;
    width: 560px;
    height: 400px;
    overflow: hidden;
    margin-top: -401px;
    right: 0px;
    position: relative;
    margin-left: calc(100% - 334px);
    display: block;
  }

  section#joinus .imagewrap.fadeup:before {
    content: "";
    width: 386px;
    height: 316px;
    display: block;
    position: relative;
    background-image: url(../images/joinus-img.png);
    background-repeat: no-repeat;
    background-size: cover;
    z-index: 999;
    position: absolute;
    margin-top: 84px;
    margin-right: 1px;
    margin-left: 60px;
    right: -14px;
    opacity: 0;
    animation: fadeup1 0.6s ease-in-out 0.8s forwards;
  }

  section#joinus .insidewrap .content-wrap {
    margin-top: 50px;
    width: calc(50% - 60px);
    display: block;
    margin-left: 30px;
    margin-right: 30px;
    text-align: center;
    font-size: 16px;
  }

  section#joinus .outsidewrap {
    display: block;
    height: 320px;
    width: 100%;
  }

  section#joinus .insidewrap {
    height: 318px;
  }
}
section#contact {
  width: 100%;
  min-height: unset;
  height: 356px;
  padding: 60px 30px 20px 30px;
  background-image: linear-gradient(104deg, #4ed497 2%, #44a8f2);
  /* GENERAL BUTTON STYLING */
  /* BUTTON secondary */
  /* BUTTON primary */
}
section#contact h3 {
  line-height: 1.8;
  letter-spacing: 6.67px;
  text-align: center;
  color: #ffffff;
  font-size: 40px;
}
section#contact p {
  font-size: 24px;
  font-weight: normal;
  font-stretch: normal;
  font-style: normal;
  line-height: 1.5;
  letter-spacing: normal;
  text-align: center;
  color: #ffffff;
}
section#contact button,
section#contact button::after {
  -webkit-transition: all 0.3s;
  -moz-transition: all 0.3s;
  -o-transition: all 0.3s;
  transition: all 0.3s;
}
section#contact button {
  min-width: 160px;
  min-height: 40px;
  padding: 12px 24px;
  border-radius: 40px;
  font-size: 16px;
  line-height: 1.5;
  font-weight: bold;
  margin-left: auto;
  margin-right: auto;
  margin-top: 40px;
}
section#contact .secondary {
  background: none;
  border: solid 1px #ff6b50;
  display: block;
  position: relative;
}
section#contact .secondary span {
  color: #ff6b50;
  z-index: 999;
  position: relative;
}
section#contact .secondary::after {
  background: linear-gradient(90deg, #ff6b50, #f03120);
  content: "";
  position: absolute;
  display: block;
}
section#contact .secondary:hover span {
  color: #ffffff;
  z-index: 999;
  position: relative;
}
section#contact .secondary::after {
  left: 50%;
  top: 20%;
  width: 0;
  height: 50%;
  opacity: 0;
}
section#contact .secondary:hover:after {
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  border-radius: 40px;
  opacity: 1;
}
section#contact .primary {
  background: #ff6b50;
  border: solid 1px #ff6b50;
  color: #fff;
  display: block;
  position: relative;
}
section#contact .primary span {
  color: #ffffff;
  z-index: 999;
  position: relative;
}
section#contact .primary::after {
  background: linear-gradient(90deg, #ff6b50, #f03120);
  content: "";
  position: absolute;
  z-index: 1;
}
section#contact .primary:hover {
  color: #fff;
  background: none;
}
section#contact .primary:hover span {
  color: #ffffff;
  z-index: 999;
  position: relative;
}
section#contact .primary::after {
  left: 50%;
  top: 20%;
  width: 0;
  height: 50%;
  opacity: 0;
  color: #fff;
}
section#contact .primary:hover:after {
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  border-radius: 40px;
  opacity: 1;
}

@media screen and (max-width: 768px) {
  section#contact {
    height: auto;
  }
  section#contact h3 {
    line-height: 1.8;
    letter-spacing: 6.67px;
    text-align: center;
    color: #ffffff;
    font-size: 24px;
  }
  section#contact p {
    font-size: 16px;
    font-weight: normal;
    font-stretch: normal;
    font-style: normal;
    line-height: 1.5;
    letter-spacing: normal;
    text-align: center;
    color: #ffffff;
  }
  section#contact button {
    margin-top: 20px;
  }
}
footer {
  width: 100%;
  min-height: 40px;
  background-image: linear-gradient(104deg, #4ed497 2%, #44a8f2);
}
footer span {
  font-size: 12px;
  font-weight: normal;
  font-stretch: normal;
  font-style: normal;
  line-height: 1.5;
  letter-spacing: normal;
  text-align: center;
  color: #ffffff;
  display: block;
  margin-left: auto;
  margin-right: auto;
  padding-top: 20px;
  padding-bottom: 20px;
}

/*# sourceMappingURL=main.cs.map */
