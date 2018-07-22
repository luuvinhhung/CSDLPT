<%@page import="model.Product"%>
<%@page import="dao.ProductDAO"%>
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
        <%
            ProductDAO productdao = new ProductDAO();
            String category_id = "";
            if (request.getParameter("category") != null) {
                category_id = request.getParameter("category");
            }
        %>
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

                                <!-- .row -->
                                <div class="tieude"><p>Các phim Hot trong tuần<p>
                                    <hr>
                                    <br>
                                </div>

                                <div class="row">
                                    <%
                                        for (Product p : productdao.getListProductByCategory(Integer.parseInt(category_id))) {
                                    %>
                                    <div class=" col-md-3">
                                        <div class="latest-movie">
                                            <a href="single.jsp?productID=<%=p.getProductID()%>"><img src="<%=p.getImg()%>"alt ="Movie 3"></a>
                                            <br>
                                            <div class="tenphim"><%=p.getProductname()%></div>
                                        </div>
                                    </div>
                                    <%
                                        }
                                    %>
                                </div> <!-- .row -->

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