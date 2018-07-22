/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import dao.ProductDAO;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import model.Product;

/**
 *
 * @author Van Khoa
 */
@WebServlet(name = "mannangerproductServlet", urlPatterns = {"/mannangerproductServlet"})
public class mannangerproductServlet extends HttpServlet {
    ProductDAO productdao = new ProductDAO();

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        
    }

  
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String command= request.getParameter("command");
         String maphim = request.getParameter("product_id");  
        long maphim1 = Long.parseLong(maphim);
        String tenphim = request.getParameter("product_name");
        String url_img = request.getParameter("product_img");
        String category = request.getParameter("phim");
        long category1 = Long.parseLong(category);
        String detail = request.getParameter("detail");
        String url="",error="";
        System.out.println("Product_id :"  + maphim1 + " categpory1 :" + category1);
        if(maphim1==0)
        {
            error="Ten danh muc phai khac 0";
            request.setAttribute("error",error);
        }
        try{
            if(error.length()==0)
            {
               switch(command)
               {
                   case "insert":
                       System.out.println("123456");
                       productdao.insert(new Product(maphim1,category1,tenphim,url_img,detail));
                       url = "/admin/mangerproduct.jsp";
               }
               
            }
            else{
                url ="/admin/mangerproduct.jsp";
            }
                 
        }catch(Exception ex){
            
        }
        RequestDispatcher rd = getServletContext().getRequestDispatcher(url);
        rd.forward(request, response);
    }

    
}
