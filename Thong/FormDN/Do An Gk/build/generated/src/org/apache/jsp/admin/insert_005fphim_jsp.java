package org.apache.jsp.admin;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class insert_005fphim_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html; charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("<c:set var=\"root\" value=\"");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${pageContext.request.contextPath}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("\"/>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <title>Thêm Phim</title>\n");
      out.write("        \n");
      out.write("\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\n");
      out.write("        <meta http-equiv=\"Copyright\" content=\"arirusmanto.com\">\n");
      out.write("        <meta name=\"description\" content=\"Admin MOS Template\">\n");
      out.write("        <meta name=\"keywords\" content=\"Admin Page\">\n");
      out.write("        <meta name=\"author\" content=\"Ari Rusmanto\">\n");
      out.write("        <meta name=\"language\" content=\"Bahasa Indonesia\">\n");
      out.write("\n");
      out.write("        <link rel=\"shortcut icon\" href=\"stylesheet/img/devil-icon.png\"> <!--Pemanggilan gambar favicon-->\n");
      out.write("        <link rel=\"stylesheet\" type=\"text/css\" href=\"");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.evaluateExpression("${pageContext.request.contextPath}", java.lang.String.class, (PageContext)_jspx_page_context, null));
      out.write("/admin/mos-css/mos-style.css\"> <!--pemanggilan file css-->\n");
      out.write("    </head>\n");
      out.write("\n");
      out.write("    <body>\n");
      out.write("        <div id=\"header\">\n");
      out.write("            <div class=\"inHeader\">\n");
      out.write("                <div class=\"mosAdmin\">\n");
      out.write("                    Hallo, Văn Khoa<br>\n");
      out.write("                    <a href=\"\">Lihat website</a> | <a href=\"\">Help</a> | <a href=\"login.html\">Keluar</a>\n");
      out.write("                </div>\n");
      out.write("                <div class=\"clear\"></div>\n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("\n");
      out.write("        <div id=\"wrapper\">\n");
      out.write("            <div id=\"leftBar\">\n");
      out.write("                <ul>\n");
      out.write("                    <li><a href=\"index.jsp\">Trang Chủ</a></li>\t\n");
      out.write("                    <li><a href=\"mangerproduct.jsp\">Phim</a></li>\n");
      out.write("                </ul>\n");
      out.write("            </div>\n");
      out.write("            <div id=\"rightContent\">\n");
      out.write("                <h3>Thêm Phim</h3>\n");
      out.write("                <form action=\"/DOANLTW/mannangerproductServlet\" method=\"post\">\n");
      out.write("                <table width=\"95%\">\n");
      out.write("                    \n");
      out.write("                    <tr><td width=\"125px\"><b>product_id</b></td><td>\n");
      out.write("                            <input type=\"text\" class=\"pendek\" name=\"product_id\"></td></tr>\n");
      out.write("                    <tr><td><b>product_name</b></td><td><input type=\"text\" class=\"sedang\" name=\"product_name\"></td></tr>\n");
      out.write("                    <tr><td><b>product_img</b></td><td><input type=\"text\" class=\"panjang\" name=\"product_img\"></td></tr>\n");
      out.write("                    <tr><td><b></b></td><td>\n");
      out.write("                            <input type=\"radio\" name=\"phim\" id=\"1\" value=\"1\">Phim Hành Động\n");
      out.write("                            <input type=\"radio\" name=\"phim\" id=\"2\" value=\"2\">Phim Kinh Dị\n");
      out.write("                            <input type=\"radio\" name=\"phim\" id=\"3\" value=\"3\">Phim Tình Cảm\n");
      out.write("                            <input type=\"radio\" name=\"phim\" id=\"4\" value=\"4\">Phim Võ Thuật\n");
      out.write("\n");
      out.write("                        </td></tr>\n");
      out.write("                 \n");
      out.write("                    <tr><td><b>detail</b></td><td><textarea name=\"detail\"></textarea></td></tr>\n");
      out.write("                    <tr><td></td><td>\n");
      out.write("                            \n");
      out.write("                     <input type=\"hidden\" name=\"command\" value=\"insert\">\n");
      out.write("                                   \n");
      out.write("                    <input type=\"submit\" class=\"button\" value=\"Lưu dữ liệu\">\n");
      out.write("                        </td></tr>\n");
      out.write("                    \n");
      out.write("                </table>\n");
      out.write("                   \n");
      out.write("                </form>\n");
      out.write("                 \n");
      out.write("            </div>\n");
      out.write("            <div class=\"clear\"></div>\n");
      out.write("            <div id=\"footer\">\n");
      out.write("              \n");
      out.write("            </div>\n");
      out.write("        </div>\n");
      out.write("    </body>\n");
      out.write("</html>");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
