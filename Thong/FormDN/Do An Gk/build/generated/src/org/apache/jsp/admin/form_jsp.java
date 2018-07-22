package org.apache.jsp.admin;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class form_jsp extends org.apache.jasper.runtime.HttpJspBase
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
      response.setContentType("text/html");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("<title>Admin MOS Template</title>\r\n");
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n");
      out.write("<meta http-equiv=\"Copyright\" content=\"arirusmanto.com\">\r\n");
      out.write("<meta name=\"description\" content=\"Admin MOS Template\">\r\n");
      out.write("<meta name=\"keywords\" content=\"Admin Page\">\r\n");
      out.write("<meta name=\"author\" content=\"Ari Rusmanto\">\r\n");
      out.write("<meta name=\"language\" content=\"Bahasa Indonesia\">\r\n");
      out.write("\r\n");
      out.write("<link rel=\"shortcut icon\" href=\"stylesheet/img/devil-icon.png\"> <!--Pemanggilan gambar favicon-->\r\n");
      out.write("<link rel=\"stylesheet\" type=\"text/css\" href=\"mos-css/mos-style.css\"> <!--pemanggilan file css-->\r\n");
      out.write("</head>\r\n");
      out.write("\r\n");
      out.write("<body>\r\n");
      out.write("<div id=\"header\">\r\n");
      out.write("\t<div class=\"inHeader\">\r\n");
      out.write("\t\t<div class=\"mosAdmin\">\r\n");
      out.write("\t\tHallo, Mas Administrator<br>\r\n");
      out.write("\t\t<a href=\"\">Lihat website</a> | <a href=\"\">Help</a> | <a href=\"login.html\">Keluar</a>\r\n");
      out.write("\t\t</div>\r\n");
      out.write("\t<div class=\"clear\"></div>\r\n");
      out.write("\t</div>\r\n");
      out.write("</div>\r\n");
      out.write("\r\n");
      out.write("<div id=\"wrapper\">\r\n");
      out.write("\t<div id=\"leftBar\">\r\n");
      out.write("\t<ul>\r\n");
      out.write("\t\t<li><a href=\"index.html\">Dashboard</a></li>\r\n");
      out.write("\t\t<li><a href=\"tabel.html\">Tabel</a></li>\r\n");
      out.write("\t\t<li><a href=\"form.html\">Form</a></li>\r\n");
      out.write("\t</ul>\r\n");
      out.write("\t</div>\r\n");
      out.write("\t<div id=\"rightContent\">\r\n");
      out.write("\t<h3>Form</h3>\r\n");
      out.write("\t\r\n");
      out.write("\t\t<div class=\"informasi\">\r\n");
      out.write("\t\tini adalah notifikasi pertanda informasi\r\n");
      out.write("\t\t</div>\r\n");
      out.write("\t\t\r\n");
      out.write("\t\t<div class=\"gagal\">\r\n");
      out.write("\t\tini adalah notifikasi pertanda gagal\r\n");
      out.write("\t\t</div>\r\n");
      out.write("\t\t\r\n");
      out.write("\t\t<div class=\"sukses\">\r\n");
      out.write("\t\tini adalah notifikasi pertanda sukses\r\n");
      out.write("\t\t</div>\r\n");
      out.write("\t\r\n");
      out.write("\t\t<table width=\"95%\">\r\n");
      out.write("\t\t\t<tr><td width=\"125px\"><b>Input text pendek</b></td><td><input type=\"text\" class=\"pendek\"></td></tr>\r\n");
      out.write("\t\t\t<tr><td><b>Input text sedang</b></td><td><input type=\"text\" class=\"sedang\"></td></tr>\r\n");
      out.write("\t\t\t<tr><td><b>Input text panjang</b></td><td><input type=\"text\" class=\"panjang\"></td></tr>\r\n");
      out.write("\t\t\t<tr><td><b>Radio</b></td><td>\r\n");
      out.write("\t\t\t\t<input type=\"radio\" name=\"radio\" id=\"radio\" value=\"radio 1\">Radio 1\r\n");
      out.write("\t\t\t\t<input type=\"radio\" name=\"radio\" id=\"radio\" value=\"radio 2\">Radio 2\r\n");
      out.write("\t\t\t</td></tr>\r\n");
      out.write("\t\t\t<tr><td><b>Checkbox</b></td><td>\r\n");
      out.write("\t\t\t\t<input type=\"checkbox\" name=\"checkbox\" id=\"checkbox\" value=\"checkbox 1\">Checkbox 1<br>\r\n");
      out.write("\t\t\t\t<input type=\"checkbox\" name=\"checkbox\" id=\"checkbox\" value=\"checkbox 2\">Checkbox 2<br>\r\n");
      out.write("\t\t\t\t<input type=\"checkbox\" name=\"checkbox\" id=\"checkbox\" value=\"checkbox 3\">Checkbox 3<br>\r\n");
      out.write("\t\t\t\t<input type=\"checkbox\" name=\"checkbox\" id=\"checkbox\" value=\"checkbox 4\">Checkbox 4<br>\r\n");
      out.write("\t\t\t</td></tr>\r\n");
      out.write("\t\t\t<tr><td><b>Pilihan</b></td><td>\r\n");
      out.write("\t\t\t\t<select>\r\n");
      out.write("\t\t\t\t\t<option selected>-- pilihan --</option>\r\n");
      out.write("\t\t\t\t\t<option value=\"\">Pilihan</option>\r\n");
      out.write("\t\t\t\t</select>\r\n");
      out.write("\t\t\t</td></tr>\r\n");
      out.write("\t\t\t<tr><td><b>Textarea</b></td><td><textarea></textarea></td></tr>\r\n");
      out.write("\t\t\t<tr><td></td><td>\r\n");
      out.write("\t\t\t<input type=\"button\" class=\"button\" value=\"Button\">\r\n");
      out.write("\t\t\t<input type=\"submit\" class=\"button\" value=\"Submit\">\r\n");
      out.write("\t\t\t<input type=\"reset\" class=\"button\" value=\"Reset\">\r\n");
      out.write("\t\t\t</td></tr>\r\n");
      out.write("\t\t</table>\r\n");
      out.write("\t</div>\r\n");
      out.write("<div class=\"clear\"></div>\r\n");
      out.write("<div id=\"footer\">\r\n");
      out.write("\t&copy; 2012 MOS css template | <a href=\"#\">Nama Website Anda</a> | design <a href=\"http://arirusmanto.com\" target=\"_blank\">arirusmanto.com</a><br>\r\n");
      out.write("\tredesign <a href=\"#\">Tulis nama anda disini</a> | Silahkan baca <a href=\"lisensi.txt\" target=\"_blank\">Lisensi</a>\r\n");
      out.write("</div>\r\n");
      out.write("</div>\r\n");
      out.write("</body>\r\n");
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
