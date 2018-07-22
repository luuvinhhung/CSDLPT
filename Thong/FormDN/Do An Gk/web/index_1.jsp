<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1">

        <title>Movie Review</title>

        <!-- Loading third party fonts -->
        <link href="http://fonts.googleapis.com/css?family=Roboto:300,400,700|" rel="stylesheet" type="text/css">
        <link href="fonts/font-awesome.min.css" rel="stylesheet" type="text/css">

        <!-- Loading main css file -->
        <link rel="stylesheet" href="style.css">

        <!--[if lt IE 9]>
        <script src="js/ie-support/html5.js"></script>
        <script src="js/ie-support/respond.js"></script>
        <![endif]-->

    </head>
    <body>	
        <div id="site-content">
            <header class="site-header">
                <div class="container">
                    <a href="index_1.jsp" id="branding">
                        <img src="images/logo.png" alt="" class="logo">
                        <div class="logo-copy">
                            <h1 class="site-title">TK Movie</h1>
                            <small class="site-description">Hãy Thưởng Thức Cùng Chúng Tôi!</small>
                        </div>
                    </a> <!-- #branding -->

                    <div class="main-navigation">
                        <button type="button" class="menu-toggle"><i class="fa fa-bars"></i></button>
                        <ul class="menu">
                            <li class="menu-item current-menu-item"><a href="index_1.jsp">Home</a></li>
                            <li class="menu-item"><a href="about.jsp">About</a></li>
                            <li class="menu-item"><a href="review.jsp">Movie reviews</a></li>
                            <li class="menu-item"><a href="contact.jsp">Contact</a></li>
                        </ul> <!-- .menu -->

                        <form action="#" class="search-form">
                            <input type="text" placeholder="Search...">
                            <button><i class="fa fa-search"></i></button>
                        </form>
                    </div> <!-- .main-navigation -->

                    <div class="mobile-navigation"></div>
                </div>
            </header>
            <main class="main-content">
                <div class="container">
                    <div class="page">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="slider">
                                    <ul class="slides">
                                        <li><a href="#"><img src="dummy/slide-1.jpg" alt="Slide 1"></a></li>
                                        <li><a href="#"><img src="dummy/slide-2.jpg" alt="Slide 2"></a></li>
                                    </ul>
                                </div>
                            </div>
                            <!--							<div class="col-md-3">
                                                                                            <div class="row">
                                                                                                    <div class="col-sm-6 col-md-12">
                                                                                                            <div class="latest-movie canh-chinh">
                                                                                                                    <a href="#"><img src="dummy/thumb-1.jpg" alt="Movie 1"></a>
                                                                                                            </div>
                                                                                                    </div>
                                                                                                    <div class="col-sm-6 col-md-12">
                                                                                                            <div class="latest-movie">
                                                                                                                    <a href="#"><img src="dummy/thumb-2.jpg" alt="Movie 2"></a>
                                                                                                            </div>
                                                                                                    </div>
                                                                                            </div>
                                                                                    </div>-->
                        </div> 

                        <!-- .row -->
                        <div class="tieude"><p>Các phim Hot trong tuần<p>
                            <hr>
                            <br>
                        </div>
                        <div id="scroll-feature" class="horiz-scroll" style="margin: 0 auto;">

                            <div class="scroller">
                                <div class="left-scroll invisible"></div>
                                <div class="right-scroll"></div>
                                <div class="scroll-images scrollable-x">
                                    <img src="dummy/phimhanhdong1.jpg" alt="Image 1">
                                    <img src="dummy/phimhanhdong2.jpg" alt="Image 2">
                                    <img src="dummy/phimhanhdong3.jpg" alt="Image 3">
                                    <img src="dummy/phimhanhdong4.jpg" alt="Image 4">
                                    <img src="dummy/phimkinhdi1.jpg" alt="Image 5">
                                    <img src="dummy/phimkinhdi2.jpg" alt="Image 6">
                                    <img src="dummy/phimkinhdi3.jpg" alt="Image 7">
                                    <img src="dummy/phimtinhcam1.jpg" alt="Image 8">
                                    <img src="dummy/phimtinhcam2.jpg" alt="Image 9">
                                    <img src="dummy/phimtinhcam3.jpg" alt="Image 10">
                                </div>
                            </div>
                        </div>
                        <!--						<div class="row">
                                                                                <div class="col-sm-6 col-md-3">
                                                                                        <div class="latest-movie">
                                                                                                <a href="#"><img src="dummy/thumb-3.jpg" alt="Movie 3"></a>
                                                                                        </div>
                                                                                </div>
                                                                                <div class="col-sm-6 col-md-3">
                                                                                        <div class="latest-movie">
                                                                                                <a href="#"><img src="dummy/thumb-4.jpg" alt="Movie 4"></a>
                                                                                        </div>
                                                                                </div>
                                                                                <div class="col-sm-6 col-md-3">
                                                                                        <div class="latest-movie">
                                                                                                <a href="#"><img src="dummy/thumb-5.jpg" alt="Movie 5"></a>
                                                                                        </div>
                                                                                </div>
                                                                                <div class="col-sm-6 col-md-3">
                                                                                        <div class="latest-movie">
                                                                                                <a href="#"><img src="dummy/thumb-6.jpg" alt="Movie 6"></a>
                                                                                        </div>
                                                                                </div>
                                                                        </div>  .row 
                                                                        <div class="row">
                                                                                <div class="col-sm-6 col-md-3">
                                                                                        <div class="latest-movie">
                                                                                                <a href="#"><img src="dummy/thumb-3.jpg" alt="Movie 3"></a>
                                                                                        </div>
                                                                                </div>
                                                                                <div class="col-sm-6 col-md-3">
                                                                                        <div class="latest-movie">
                                                                                                <a href="#"><img src="dummy/thumb-4.jpg" alt="Movie 4"></a>
                                                                                        </div>
                                                                                </div>
                                                                                <div class="col-sm-6 col-md-3">
                                                                                        <div class="latest-movie">
                                                                                                <a href="#"><img src="dummy/thumb-5.jpg" alt="Movie 5"></a>
                                                                                        </div>
                                                                                </div>
                                                                                <div class="col-sm-6 col-md-3">
                                                                                        <div class="latest-movie">
                                                                                                <a href="#"><img src="dummy/thumb-6.jpg" alt="Movie 6"></a>
                                                                                        </div>
                                                                                </div>
                                                                        </div>  .row 
                                                                        
                                                                        
                                                </main>
                                                <footer class="site-footer">
                                                        <div class="container">
                                                                <div class="row">
                                                                        <div class="col-md-4">
                                                                                <div class="widget">
                                                                                        <h3 class="widget-title">Giới Thiệu</h3>
                                                                                        <p style="padding-right: 105px;">Đây là wed giới thiệu phim các bộ phim hay nhất và mới nhất!</p>
                                                                                </div>
                                                                        </div>
                                                                        <div class="col-md-4">
                                                                                <div class="widget">
                                                                                        <h3 class="widget-title">Rạp Chiếu</h3>
                                                                                        <ul class="no-bullet">
                                                                                                <li><a href="#">BHD Cinemar</a></li>
                                                                                                <li><a href="#">CGV Cinemar</a></li>
                                                                                                <li><a href="#">Galaxy Cinemar</a></li>
                                                                                        </ul>
                                                                                </div>
                                                                        </div>
                                                                        <div class="col-md-4">
                                                                                <div class="widget">
                                                                                        <h3 class="widget-title">Liên hệ</h3>
                                                                                        <ul class="no-bullet">
                                                                                                <li><a href="#">Đường giây nóng: 01643026275</a></li>
                                                                                        </ul>
                                                                                </div>
                                                                        </div>
                                                                </div>  .row -->

                     
                    </div> <!-- .container -->
                    <footer>
                        <br>
                        <br>
                        <br>
                           <div class="colophon">Copyright 2017 Company name, Designed by Van Khoa. All rights reserved</div>
                    </footer>
                   
                </div>
                <!-- Default snippet for navigation -->



                <script src="js/jquery-1.11.1.min.js"></script>
                <script src="js/plugins.js"></script>
                <script src="js/app.js"></script>
                <style>
                    body {
  margin: 0;
  padding: 0;
  font-family: 'Source Sans Pro', sans-serif;
}
 
h1, h2, p {
  text-align: center;
}
 
h1 {
  font-size: 3em;
}
 
h2 {
  font-size: 2em;
  margin: 40px 0 0;
}
 
p {
  font-size: 1.5em;
  margin-top: .5em;
}
 
#responsive-sizing {
  text-align: center;
}
 
#responsive-sizing .spec {
  display: inline-block;
  margin: 10px 10px 10px 0;
}
 
#responsive-sizing .breakpoint {
  background-color: #333;
  color: white;
  border-radius: 5px 0 0 5px;
}
 
#responsive-sizing .vis-image-count {
  border-radius: 0 5px 5px 0;
  background-color: #ddd;
}
 
#responsive-sizing .breakpoint,
#responsive-sizing .vis-image-count {
  padding: 5px 10px;
}
 
/* Begin Scroller Rules */
.horiz-scroll {
  display: flex;
  display: -webkit-flex;
  flex-direction: column;
  -webkit-flex-direction: column;
  overflow: visible;
  position: relative;
}
 
.horiz-scroll h2 {
  font-weight: 600;
}
 
.horiz-scroll .scroller {
  max-height: 30vw;
  position: relative;
  display: flex;
  display: -webkit-flex;
  flex: 1;
  -webkit-flex: 1;
  background-color: white;
}
 
.horiz-scroll .scroller .left-scroll {
  left: 0;
}
 
.horiz-scroll .scroller .right-scroll {
  right: 0;
}
 
.horiz-scroll .scroller .left-scroll,
.horiz-scroll .scroller .right-scroll {
  display: flex;
  display: -webkit-flex;
  flex-direction: column;
  -webkit-flex-direction: column;
  padding: 0 2vw;
  overflow-x: hidden;
  z-index: 1;
  justify-content: center;
  -webkit-justify-content: center;
  position: absolute;
  height: 100%;
}
 
.horiz-scroll .scroller .left-scroll p,
.horiz-scroll .scroller .right-scroll p {
  font-size: 3em;
  color: white;
  text-shadow: 0 0 10px #333;
  margin: 0;
}
 
@media only screen and (max-width: 480px) {
  .horiz-scroll .scroller .left-scroll p,
  .horiz-scroll .scroller .right-scroll p {
    color: black;
  }
}
 
.horiz-scroll .scroller .scrollable-x {
  white-space: nowrap;
  overflow-x: scroll;
  overflow-y: hidden;
}
 
.horiz-scroll .scroller .scrollable-x::-webkit-scrollbar {
  display: none;
}
 
.horiz-scroll .scroller .scrollable-x::-webkit-scrollbar {
  width: .375em;
  max-width: 12px;
}
 
.horiz-scroll .scroller .scrollable-x::-webkit-scrollbar-track {
  background-color: transparent;
}
 
.horiz-scroll .scroller .scrollable-x::-webkit-scrollbar-thumb {
  background-color: rgba(255, 255, 255, 0.25);
  border-radius: 1em;
}
 
.horiz-scroll .scroller .scroll-images {
  position: relative;
  flex: 8;
  -webkit-flex: 8;
  order: 2;
  -webkit-order: 2;
  z-index: 0;
  font-size: 0;
  overflow-y: visible;
  padding: 10% 0;
  margin: -10% 0;
  text-align: center;
}
 
.horiz-scroll .scroller .scroll-images img {
  width: 25%;
  top: 0;
  z-index: 0;
  -webkit-transition: all 100ms;
  transition: all 100ms;
  position: relative;
}
 
@media only screen and (max-width: 960px) {
  .horiz-scroll .scroller .scroll-images img {
    width: 33.333%;
  }
}
 
@media only screen and (max-width: 720px) {
  .horiz-scroll .scroller .scroll-images img {
    width: 50%;
  }
}
 
@media only screen and (max-width: 480px) {
  .horiz-scroll .scroller .scroll-images img {
    width: 50%;
    margin: 0 25%;
  }
}
 

.invisible {
  opacity: 0;
  transition: .05s ease-in-out;
}
                </style>
                <script>
                    function HorizontalScroller(elem) {
  this.scrollbox = elem; // The scrollers viewable area
  this.scrollImages = this.scrollbox.find("img");
  this.leftScrollControl = this.scrollbox.siblings(".left-scroll");
  this.rightScrollControl = this.scrollbox.siblings(".right-scroll");
 
  // Listener to change visibility of left and right controls
  // when at scroll extremes
  this.scrollbox.on("scroll", this.evaluateControlVisibility.bind(this));
};
 
HorizontalScroller.prototype = {
   
  scrollboxWidth: function() {
    return this.scrollbox.outerWidth(true);
  }, 
 
  currentScrollPosition: function() {
    return this.scrollbox.scrollLeft();
  },
 
  currentRightPosition: function() {
    return this.currentScrollPosition() + this.scrollboxWidth() - this.totalWidths();
  },
 
  // Maps the image width of each image in the scroller
  imageWidths: function() {
    return $.map(this.scrollImages, function(img) { 
      return $(img).outerWidth(true);
    })
  },
 
  // Returns the total width of all the images, that is,
  // the total of the visible and overflow content.
  totalWidths: function() {
    return this.imageWidths().reduce(function(a,b) { return a+b});
  },
 
  // Returns the average width of all the images
  avgWidth: function() {
    return this.totalWidths() / this.imageWidths().length;
  },
 
  // Determines the number of images in view area.
  // Number of images changes with responsive CSS
  imagesAcross: function() {
    return Math.round( this.scrollboxWidth() / this.avgWidth() );
  },
 
  // maps the offset x-distance of each image
  // from the left edge of the view area
  imageOffsets: function() {
    return $.map(this.scrollImages, function(img) { 
      return Math.round($(img).position().left);
    }); 
  },
 
  // Returns the index of the first number in the given array
  // greater than the given value, or, returns the index of
  // the first positive number in the array
  indexOfFirst: function(array, value) {
    value = value || 0;
    var firstIndex;
    var i = 0;
    while (firstIndex === undefined && array.length > i) {
      if (array[i] >= value)
        firstIndex = i; 
      i += 1;
    }
    return firstIndex; 
  },
 
  // Returns the index of first image that is completely in view
  // within the scrollbox
  firstVisibleImageIndex: function() {
    return this.indexOfFirst(this.imageOffsets());
  },
 
  // Returns the first image that is completely in view 
  // within the scrollbox
  firstVisibleImage: function() {
    return this.scrollImages[this.firstVisibleImageIndex()];
  },
 
  // Returns the index of the last image with its left edge in view 
  // within the scrollbox
  lastVisibleImageIndex: function() {
    return this.firstVisibleImageIndex() + this.imagesAcross();
  },
 
  // Returns the last image with its left edge in view 
  // within the scrollbox
  lastVisibleImage: function() {
    return this.scrollImages[this.lastVisibleImageIndex()];
  },
 
  // Returns the difference between the scrollboxes left edge
  // and the left edge of the first fully visible image, that is,
  // how far in the first fully visible image is
  offset: function() {
    var offset = $(this.firstVisibleImage()).position().left;
    return Math.round(offset);
  },
   
  // Returns the combined scroll amount that the images have to travel
  // in order to land evenly within the scroll window. The resulting
  nextScrollPosition: function(direction) {
    var nextScrollPosition = this.currentScrollPosition() + this.offset();
 
    switch(direction) {
      case "left":
        nextScrollPosition -= this.scrollboxWidth();
        if (($(this.firstVisibleImage()).outerWidth(true) - this.offset()) < 0) { nextScrollPosition -= $(this.firstVisibleImage()).outerWidth(true); } break; case "right": nextScrollPosition += this.scrollboxWidth(); if (this.offset() > 0) {
          nextScrollPosition -= $(this.firstVisibleImage()).outerWidth(true);
        }
        break;
    }
    return nextScrollPosition;
  },
 
  // Triggers the animation
  animateScroll: function(direction) {
    resetFocusedImg();
    var scroller = this;
    setTimeout(function() {
      scroller.scrollbox.animate({
        scrollLeft: scroller.nextScrollPosition(direction)
      }, this.scrollboxWidth())
    }.bind(this), 100);
  },
 
  hideScrollControl: function(control) {
    control.addClass("invisible");
  },
 
  showScrollControl: function(control) {
    control.removeClass("invisible");
  },
 
  scrollControlVisibility: function(control) {
    return control.hasClass("invisible");
  },
   
  scrollAtZero: function() {
    return this.currentScrollPosition() == 0;
  },
 
  scrollAtMax: function() {
    return this.currentRightPosition() >= -1;
  },
 
  evaluateControlVisibility: function() {
    var left = this.leftScrollControl;
    var right = this.rightScrollControl;
    var leftIsInvisible = this.scrollControlVisibility(left);
    var rightIsInvisible = this.scrollControlVisibility(right);
 
    if (this.scrollAtZero()) this.hideScrollControl(left);
    if (this.scrollAtMax()) this.hideScrollControl(right);
    if (!this.scrollAtZero() && leftIsInvisible) this.showScrollControl(left);
    if (!this.scrollAtMax() && rightIsInvisible) this.showScrollControl(right);
  }
};
 
// End HorizontalScroller.prototype
 
var scrollers = {};
 
// Detects scrollers in the DOM
function detectScrollers() {
  return $.map($(".horiz-scroll"), function(scroller) {
    return $(scroller).attr("id");
  });
}
 
// Generates a new HorizontalScroller for each scroller in DOM
function mapScrollers(scrollerIds) {
  scrollerIds.forEach(function(elem, i , arr) {
    var scroller = "#" + elem + " .scroll-images";
    scrollers[elem] = new HorizontalScroller( $(scroller) );
  });
}
 
// Gets the scroll direction to pass to animation function
function getScrollDirection(button) {
  return (button.hasClass("left-scroll")) ? "left" : "right"
}
 
// Triggers the scroll animation for specific scroller
// in a specific direction
function triggerAnimation(button) {
  var scrollId = button.closest(".horiz-scroll").attr("id");
  var scrollDirection = getScrollDirection(button);
  scrollers[scrollId].animateScroll(scrollDirection);
}
 
// Scroll buttons listener
function listenForScroll() {
  $(".left-scroll, .right-scroll").on("click", function() {
    var button = $(this);
    triggerAnimation(button);
  });
}
 
function resetFocusedImg() {
  $(".focused").removeClass("focused");
}
 
// listener for click, slides up
var horizontalScrollImg = $(".horiz-scroll .scroll-images img");
horizontalScrollImg.on("click", function() {
  if (!$(this).hasClass("focused"))
    resetFocusedImg();
  $(this).toggleClass("focused");
});
 
// Registers scrollers and initiates listeners 
function scrollerInit() {
  var scrollerIds = detectScrollers();
  mapScrollers(scrollerIds);
  listenForScroll();
}
 
// Begins the fun
scrollerInit();
</script>
                 </script>
                </body>

                </html>