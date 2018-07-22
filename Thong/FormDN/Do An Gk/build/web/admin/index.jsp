<c:set var="root" value="${pageContext.request.contextPath}"/>
<html>
    <head>
        <title>Admin MOS Template</title>
        <%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta http-equiv="Copyright" content="arirusmanto.com">
        <meta name="description" content="Admin MOS Template">
        <meta name="keywords" content="Admin Page">
        <meta name="author" content="Ari Rusmanto">
        <meta name="language" content="Bahasa Indonesia">

        <link rel="shortcut icon" href="stylesheet/img/devil-icon.png"> <!--Pemanggilan gambar favicon-->
        <link rel="stylesheet" type="text/css" href="${pageContext.request.contextPath}/admin/mos-css/mos-style.css"> <!--pemanggilan file css-->
    </head>

    <body>
        <div id="header">
            <div class="inHeader">
                <div class="mosAdmin">
                    Hallo, Mas Administrator<br>
                    <a href="">Lihat website</a> | <a href="">Help</a> | <a href="login.html">Keluar</a>
                </div>
                <div class="clear"></div>
            </div>
        </div>

        <div id="wrapper">
            <div id="leftBar">
                <ul>
                    <li><a href="index.jsp">Trang Chủ</a></li>
                  
                    <li><a href="mangerproduct.jsp">Phim</a></li>
                </ul>
            </div>
            <div id="rightContent">
                <h3>Trang Chu</h3>
                <div class="quoteOfDay">
                    <span>Chao Mung Ban Den Voi Trang Admin Review Phim ! </span>
                </div>
                

                <div class="clear"></div>

            </div>
            <div class="clear"></div>
            <div id="footer">
                &copy; 2012 MOS css template | <a href="#">Nama Website Anda</a> | design <a href="http://arirusmanto.com" rel="nofollow" target="_blank">arirusmanto.com</a><br>
                redesign <a href="#">Tulis nama anda disini</a> 
            </div>
        </div>
    </body>
</html>