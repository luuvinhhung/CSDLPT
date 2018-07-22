/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import connect.DBconnect;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import model.Product;
import org.jboss.logging.Logger;
import sun.util.logging.PlatformLogger;

/**
 *
 * @author Van Khoa
 */
public class ProductDAO {

    // get danh sach phim
      public ArrayList<Product> getListProduct() throws SQLException {
        Connection connection = DBconnect.getConnecttion();
        String sql = "SELECT * FROM product";
        PreparedStatement ps = connection.prepareCall(sql);
        ResultSet rs = ps.executeQuery();
        ArrayList<Product> list = new ArrayList<>();
        while (rs.next()) {
            Product product = new Product();
            product.setProductID(rs.getLong("product_id"));
            product.setProductname(rs.getString("product_name"));
            product.setImg(rs.getString("product_img"));
            product.setCategoryID(rs.getLong("category_id"));
            product.setDetail(rs.getString("detail"));
            list.add(product);
        }
        return list;
    }
    public ArrayList<Product> getListProductByCategory(long category_id) throws SQLException {
        Connection connection = DBconnect.getConnecttion();
        String sql = "SELECT * FROM product WHERE category_id = '" + category_id + "'";
        PreparedStatement ps = connection.prepareCall(sql);
        ResultSet rs = ps.executeQuery();
        ArrayList<Product> list = new ArrayList<>();
        while (rs.next()) {
            Product product = new Product();
            product.setProductID(rs.getLong("product_id"));
            product.setProductname(rs.getString("product_name"));
            product.setImg(rs.getString("product_img"));
            product.setDetail(rs.getString("detail"));
            list.add(product);
        }
        return list;
    }

    public Product getProduct(long productID) throws SQLException {
        Connection connection = DBconnect.getConnecttion();
        String sql = "SELECT * FROM product WHERE product_id = '" + productID + "'";
        PreparedStatement ps = connection.prepareCall(sql);
        ResultSet rs = ps.executeQuery();
        Product product = new Product();
        while (rs.next()) {
            product.setProductID(rs.getLong("product_id"));
            product.setProductname(rs.getString("product_name"));
            product.setImg(rs.getString("product_img"));
            product.setDetail(rs.getString("detail"));
        }
        return product;
    }

    // them du lieu
    public boolean insert(Product c) throws SQLException {
        Connection connection = DBconnect.getConnecttion();
        String sql = "INSERT INTO product VALUES (?,?,?,?,?)";
        try {
            PreparedStatement ps = connection.prepareCall(sql);
           ps.setLong(1, c.getProductID()); 
            ps.setString(2, c.getProductname()); 
            ps.setString(3, c.getImg());
            ps.setLong(4, c.getCategoryID());
          
           
            ps.setString(5, c.getDetail());
            int temp = ps.executeUpdate();
            return temp == 1;

        } catch (SQLException ex) {
           //Logger.getLogger(ProductDAO.class.getName()).log(Level.SEVERE,null,ex);
            return false;
        }

    }

    public boolean update(Product c) throws SQLException {
        try {
            Connection connection = DBconnect.getConnecttion();
            String sql = "UPDATE product SET product_name = ? , product_img = ? , detail = ? WHERE product_id = ?";
            PreparedStatement ps = connection.prepareCall(sql);
            ps.setString(1, c.getProductname()); 
            ps.setString(2, c.getImg());          
           ps.setString(3, c.getDetail());
            ps.setLong(4, c.getProductID()); 
            //ps.setLong(5, c.getCategoryID());
            int temp = ps.executeUpdate();
            return temp == 1;
        } catch (Exception ex) {
            return false;
        }
    }
    
public boolean delete(long product_id) throws SQLException {
    try {
        Connection connection = DBconnect.getConnecttion();
        String sql = "DELETE FROM product WHERE product_id = ?";
        PreparedStatement ps = connection.prepareCall(sql);
        ps.setLong(1, product_id);
        int temp = ps.executeUpdate();
            return temp == 1;
    } catch (Exception e) {
        return false;
    }
}
    public static void main(String[] args) throws SQLException {
        ProductDAO dao = new ProductDAO();
    }

}
