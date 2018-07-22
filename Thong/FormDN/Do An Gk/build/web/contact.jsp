<!DOCTYPE html>
<html lang="en">
    <head>
       
        <%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1">

        <title>Movie Review | Contact</title>

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
                    <a href="index.html" id="branding">
                        <img src="images/logo.png" alt="" class="logo">
                        <div class="logo-copy">
                            <h1 class="site-title">TK Movie</h1>
                            <small class="site-description">Hãy thưởng thức cùng chúng tôi!</small>
                        </div>
                    </a> <!-- #branding -->

                    <div class="main-navigation">
                        <button type="button" class="menu-toggle"><i class="fa fa-bars"></i></button>
                        <ul class="menu">
                            <li class="menu-item"><a href="index_1.jsp">Home</a></li>
                            <li class="menu-item"><a href="about.jsp.jsp">About</a></li>
                            <li class="menu-item"><a href="review.jsp">Movie reviews</a></li>
                            <li class="menu-item current-menu-item"><a href="contact.jsp">Contact</a></li>
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
                        <div class="breadcrumbs">
                            <a href="index_1.html">Home</a>
                            <span>Contact</span>
                        </div>

                        <div class="content">
                            <div class="row">
                                <div class="col-md-4">
                                    <h2>Contact</h2>
                                    <ul class="contact-detail">
                                        <li>
                                            <img src="images/icon-contact-map.png" alt="#">
                                            <address><span>TK company</span> <br>97 Man Thiện, Hiệp Phú, Quận 9, TPHCM</address>
                                        </li>
                                        <li>
                                            <img src="images/icon-contact-phone.png" alt="">
                                            <a href="tel:1590912831">+84 126 480 6548</a>
                                        </li>
                                        <li>
                                            <img src="images/icon-contact-message.png" alt="">
                                            <a href="mailto:contact@companyname.com">tk@companyname.com</a>
                                        </li>
                                    </ul>
                                    <div class="contact-form">
                                        <input type="text" class="name" placeholder="name...">
                                        <input type="text" class="email" placeholder="email...">
                                        <input type="text" class="website" placeholder="website...">
                                        <textarea class="message" placeholder="message..."></textarea>
                                        <input type="submit" value="Gửi tin nhắn">
                                    </div>
                                </div>
                                <div class="col-md-7 col-md-offset-1">
                                    <div class="map"><iframe src="https://www.google.com/maps/embed?pb=!1m23!1m12!1m3!1d3918.5164959195113!2d106.78414071404816!3d10.848265160831774!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!4m8!3e3!4m0!4m5!1s0x3175276bb276eaf7%3A0x56a6a0eafe0e3b09!2zOTcgTWFuIFRoaeG7h24sIEhp4buHcCBQaMO6LCBRdeG6rW4gOSwgSOG7kyBDaMOtIE1pbmgsIFZpZXRuYW0!3m2!1d10.848259899999999!2d106.7863294!5e0!3m2!1sen!2s!4v1504876148129" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div> <!-- .container -->
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
					</div> <!-- .row -->

					<div class="colophon">Copyright 2017 Company name, Designed by Van Khoa. All rights reserved</div>
				</div> <!-- .container -->

			</footer>
        </div>
        <!-- Default snippet for navigation -->



        <script src="js/jquery-1.11.1.min.js"></script>

        <script src="js/plugins.js"></script>
        <script src="js/app.js"></script>

    </body>

</html>