<c:set var="root" value="${pageContext.request.contextPath}"/>
<html>
    <head>
        <title>Thêm Phim</title>
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
                    Hallo, Văn Khoa<br>
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
                <h3>Thêm Phim</h3>
                <form action="/DOANLTW/mannangerproductServlet" method="post">
                <table width="95%">
                    
                    <tr><td width="125px"><b>product_id</b></td><td>
                            <input type="text" class="pendek" name="product_id"></td></tr>
                    <tr><td><b>product_name</b></td><td><input type="text" class="sedang" name="product_name"></td></tr>
                    <tr><td><b>product_img</b></td><td><input type="text" class="panjang" name="product_img"></td></tr>
                    <tr><td><b></b></td><td>
                            <input type="radio" name="phim" id="1" value="1">Phim Hành Động
                            <input type="radio" name="phim" id="2" value="2">Phim Kinh Dị
                            <input type="radio" name="phim" id="3" value="3">Phim Tình Cảm
                            <input type="radio" name="phim" id="4" value="4">Phim Võ Thuật
                        </td></tr>
                 
                    <tr><td><b>detail</b></td><td><textarea name="detail"></textarea></td></tr>
                    <tr><td></td><td>
                            
                     <input type="hidden" name="command" value="insert">
                                   
                    <input type="submit" class="button" value="Lưu dữ liệu">
                        </td></tr>
                    
                </table>
                   
                </form>
                 
            </div>
            <div class="clear"></div>
            <div id="footer">
              
            </div>
        </div>
    </body>
</html>