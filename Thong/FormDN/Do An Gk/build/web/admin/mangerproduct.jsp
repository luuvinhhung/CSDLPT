<%@page import="model.Product"%>
<%@page import="java.util.ArrayList"%>
<%@page import="dao.ProductDAO"%>
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
        <%
            ProductDAO productdao = new ProductDAO();


        %>
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
                    <li><a href="${pageContext.request.contextPath}/admin/index.jsp">Trang Chủ</a></li>
                    <li><a href="mangerproduct.jsp">Phim</li>
                </ul>
            </div>
            <div id="rightContent">
                <h3>Quản Lí Sản Phẩm </h3>
                <a href="${pageContext.request.contextPath}/admin/insert_phim.jsp" style="font-size: 20px;">Thêm Phim</a>
                <table class="data">
                    <tr class="data">
                        <th class="data" width="30px">product_id</th>
                        <th class="data">product_name</th>
                        <th class="data">product_img</th>
                        <th class="data">catogory_id</th>
                        <th class="data">detail</th>

                        <th class="data" width="75px">Bạn Muốn</th>
                    </tr>
                    <%
                    for(Product p:productdao.getListProduct())
                    {
                    %>
                    <tr class="data">
                        <td class="data" width="30px"><%=p.getProductID()%></td>
                        <td class="data"><%=p.getProductname()%></td>
                        <td class="data"><img src="${pageContext.request.contextPath}/<%=p.getImg()%>"</td>
                        <td class="data"><%=p.getCategoryID()%></td>
                        <td class="data"><%=p.getDetail()%></td>
                        <td class="data" width="75px">
                    <center>
                        <a href="/DOANLTW/DeleteproductServlet?product_id=<%=p.getProductID()%>">Xóa | </a>
                        <a href="update_phim.jsp?product_id=<%=p.getProductID()%>">Sửa</a>
                    </center>
                    </td>
                    </tr>
                    <%}%>
                </table>
            </div>
            <div class="clear"></div>
            <div id="footer">
                &copy; 2012 MOS css template | <a href="#">Nama Website Anda</a> | design <a href="http://arirusmanto.com" target="_blank">arirusmanto.com</a><br>
                redesign <a href="#">Tulis nama anda disini</a> | Silahkan baca <a href="lisensi.txt" target="_blank">Lisensi</a>
            </div>
        </div>
    </body>
</html>