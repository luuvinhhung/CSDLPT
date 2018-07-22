<%@page import="dao.CategoryDAO"%>
<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0,maximum-scale=1">

        <title>Movie Review | About</title>

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
                            <small class="site-description">Hãy thưởng thức cùng chúng tôi!</small>
                        </div>
                    </a> <!-- #branding -->

                    <div class="main-navigation">
                        <button type="button" class="menu-toggle"><i class="fa fa-bars"></i></button>
                        <ul class="menu">
                            <li class="menu-item"><a href="index_1.jsp">Home</a></li>
                            <li class="menu-item current-menu-item"><a href="about.jsp">About</a></li>
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
                        <div class="breadcrumbs">
                            <a href="index.jsp">Home</a>
                            <span>About us</span>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <figure><img src="images/TK.png"  alt="figure image"></figure>
                            </div>
                            <div class="col-md-8">
                                <h3 class="leading"><b>Kho phim lớn, nguồn phim đa dạng từ Âu Mỹ, Hàn Quốc, Trung Quốc, được Việt hóa chất lượng tốt. TK cũng cập nhật thường xuyên các bộ phim Việt Nam vừa chiếu rạp.</b></h3>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-9">
                                <h2 class="section-title">Wed Giới Thiệu Phim

                                </h2>
                                <p>Được cung cấp bởi dựa trên các hãng chiếu phim lớn trong nước như : CGV, BHD, Galaxy cung cấp để quảng cáo.

                                </p>

                                <p>Wed phim này được cập nhật hàng ngày, hàng tuần để các bạn có nhu cầu mê phim nắm bắt thông tin.
                                </p>
                            </div>
                            <div class="col-md-3">

                            </div>
                        </div> <!-- .row -->

                        <h2 class="section-title">Chúng tôi gồm có:</h2>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="team">
                                    <figure class="team-image"><img src="dummy/person-3.jpg" alt=""></figure>
                                    <h2 class="team-name">Huỳnh Văn Khoa</h2>
                                    <small class="team-title">Reviewer</small>
                                    <div class="social-links">
                                        <a href="" class="facebook"><i class="fa fa-facebook"></i></a>
                                        <a href="" class="twitter"><i class="fa fa-twitter"></i></a>
                                        <a href="" class="google-plus"><i class="fa fa-google-plus"></i></a>
                                        <a href="" class="pinterest"><i class="fa fa-pinterest"></i></a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="team">
                                    <figure class="team-image"><img src="dummy/person-4.jpg" alt=""></figure>
                                    <h2 class="team-name">Phan Văn Thông</h2>
                                    <small class="team-title">Reviewer</small>
                                    <div class="social-links">
                                        <a href="" class="facebook"><i class="fa fa-facebook"></i></a>
                                        <a href="" class="twitter"><i class="fa fa-twitter"></i></a>
                                        <a href="" class="google-plus"><i class="fa fa-google-plus"></i></a>
                                        <a href="" class="pinterest"><i class="fa fa-pinterest"></i></a>
                                    </div>
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