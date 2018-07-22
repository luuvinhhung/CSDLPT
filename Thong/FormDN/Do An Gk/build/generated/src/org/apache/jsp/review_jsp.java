package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import model.Product;
import dao.ProductDAO;
import model.Category;
import dao.CategoryDAO;

public final class review_jsp extends org.apache.jasper.runtime.HttpJspBase
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

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html lang=\"en\">\n");
      out.write("\n");
      out.write("    <head>\n");
      out.write("        <meta charset=\"UTF-8\">\n");
      out.write("        \n");
      out.write("\n");
      out.write("        <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n");
      out.write("        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0,maximum-scale=1\">\n");
      out.write("\n");
      out.write("        <title>Movie Review | Review</title>\n");
      out.write("\n");
      out.write("        <!-- Loading third party fonts -->\n");
      out.write("        <link href=\"http://fonts.googleapis.com/css?family=Roboto:300,400,700|\" rel=\"stylesheet\" type=\"text/css\">\n");
      out.write("        <link href=\"fonts/font-awesome.min.css\" rel=\"stylesheet\" type=\"text/css\">\n");
      out.write("\n");
      out.write("        <!-- Loading main css file -->\n");
      out.write("        <link rel=\"stylesheet\" href=\"style.css\">\n");
      out.write("\n");
      out.write("        <!--[if lt IE 9]>\n");
      out.write("                <script src=\"js/ie-support/html5.js\"></script>\n");
      out.write("                <script src=\"js/ie-support/respond.js\"></script>\n");
      out.write("                <![endif]-->\n");
      out.write("\n");
      out.write("    </head>\n");
      out.write("\n");
      out.write("\n");
      out.write("    <body>\n");
      out.write("\n");
      out.write("        ");

            CategoryDAO categorydao = new CategoryDAO();

        
      out.write("\n");
      out.write("        <div id=\"site-content\">\n");
      out.write("            <header class=\"site-header\">\n");
      out.write("                <div class=\"container\">\n");
      out.write("                    <a href=\"index_1.jsp\" id=\"branding\">\n");
      out.write("                        <img src=\"images/logo.png\" alt=\"\" class=\"logo\">\n");
      out.write("                        <div class=\"logo-copy\">\n");
      out.write("                            <h1 class=\"site-title\">TK movie</h1>\n");
      out.write("                            <small class=\"site-description\">Hãy thưởng thức cùng chúng tôi !</small>\n");
      out.write("                        </div>\n");
      out.write("                    </a>\n");
      out.write("                    <!-- #branding -->\n");
      out.write("\n");
      out.write("                    <div class=\"main-navigation\">\n");
      out.write("                        <button type=\"button\" class=\"menu-toggle\"><i class=\"fa fa-bars\"></i></button>\n");
      out.write("                        <ul class=\"menu\">\n");
      out.write("                            <li class=\"menu-item\"><a href=\"index_1.jsp\">Home</a></li>\n");
      out.write("                            <li class=\"menu-item\"><a href=\"about.jsp\">About</a></li>\n");
      out.write("                            <li class=\"menu-item current-menu-item\"><a href=\"review.jsp\">Movie reviews</a></li>\n");
      out.write("                            <li class=\"menu-item\"><a href=\"contact.jsp\">Contact</a></li>\n");
      out.write("                        </ul>\n");
      out.write("                        <!-- .menu -->\n");
      out.write("\n");
      out.write("                        <form action=\"#\" class=\"search-form\">\n");
      out.write("                            <input type=\"text\" placeholder=\"Search...\">\n");
      out.write("                            <button><i class=\"fa fa-search\"></i></button>\n");
      out.write("                        </form>\n");
      out.write("                    </div>\n");
      out.write("                    <!-- .main-navigation -->\n");
      out.write("\n");
      out.write("                    <div class=\"mobile-navigation\"></div>\n");
      out.write("                </div>\n");
      out.write("            </header>\n");
      out.write("            <main class=\"main-content\">\n");
      out.write("                <div class=\"container\">\n");
      out.write("                    <div class=\"page\">\n");
      out.write("                        <div class=\"breadcrumbs\">\n");
      out.write("                            <a href=\"index.html\">Home</a>\n");
      out.write("                            <span>Movie Review</span>\n");
      out.write("                        </div>\n");
      out.write("\n");
      out.write("                        <div class=\"filters\">\n");
      out.write("\n");
      out.write("                            ");
                                    for (Category c : categorydao.getListCategory()) {
                            
      out.write("\n");
      out.write("\n");
      out.write("                            <a class=\"a");
      out.print(c.getCategoryID() + "a");
      out.write("\" href=\"film.jsp?category=");
      out.print(c.getCategoryID());
      out.write("\" style=\"padding-right: 5px; background: orange;padding: 30px;color: white;margin-right: 40px;\">");
      out.print(c.getCategoryName());
      out.write("</a>\n");
      out.write("\n");
      out.write("                            ");

                                }
                            
      out.write("\n");
      out.write("\n");
      out.write("                        </div>     \n");
      out.write("                            <div class=\"slider\">\n");
      out.write("                        <ul class=\"slides\">\n");
      out.write("                            <li><a href=\"#\"><img src=\"dummy/slide-1.jpg\" alt=\"Slide 1\"></a></li>\n");
      out.write("                            <li><a href=\"#\"><img src=\"dummy/slide-2.jpg\" alt=\"Slide 2\"></a></li>\n");
      out.write("                        </ul>\n");
      out.write("                    </div>\n");
      out.write("                    </div>\n");
      out.write("                    \n");
      out.write("                </div>\n");
      out.write("                <!-- .container -->\n");
      out.write("            </main>\n");
      out.write("            <footer class=\"site-footer\">\n");
      out.write("                <div class=\"container\">\n");
      out.write("                    <div class=\"row\">\n");
      out.write("                        <div class=\"col-md-4\">\n");
      out.write("                            <div class=\"widget\">\n");
      out.write("                                <h3 class=\"widget-title\">Giới Thiệu</h3>\n");
      out.write("                                <p style=\"padding-right: 105px;\">Đây là wed giới thiệu phim các bộ phim hay nhất và mới nhất!</p>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                        <div class=\"col-md-4\">\n");
      out.write("                            <div class=\"widget\">\n");
      out.write("                                <h3 class=\"widget-title\">Rạp Chiếu</h3>\n");
      out.write("                                <ul class=\"no-bullet\">\n");
      out.write("                                    <li><a href=\"#\">BHD Cinemar</a></li>\n");
      out.write("                                    <li><a href=\"#\">CGV Cinemar</a></li>\n");
      out.write("                                    <li><a href=\"#\">Galaxy Cinemar</a></li>\n");
      out.write("                                </ul>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                        <div class=\"col-md-4\">\n");
      out.write("                            <div class=\"widget\">\n");
      out.write("                                <h3 class=\"widget-title\">Liên hệ</h3>\n");
      out.write("                                <ul class=\"no-bullet\">\n");
      out.write("                                    <li><a href=\"#\">Đường giây nóng: 01643026275</a></li>\n");
      out.write("                                </ul>\n");
      out.write("                            </div>\n");
      out.write("                        </div>\n");
      out.write("                    </div> <!-- .row -->\n");
      out.write("\n");
      out.write("                    <div class=\"colophon\">Copyright 2017 Company name, Designed by Van Khoa. All rights reserved</div>\n");
      out.write("                </div> <!-- .container -->\n");
      out.write("\n");
      out.write("            </footer>\n");
      out.write("        </div>\n");
      out.write("        <!-- Default snippet for navigation -->\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("        <script src=\"js/jquery-1.11.1.min.js\"></script>\n");
      out.write("        <script src=\"js/plugins.js\"></script>\n");
      out.write("        <script src=\"js/app.js\"></script>\n");
      out.write("\n");
      out.write("    </body>\n");
      out.write("\n");
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
