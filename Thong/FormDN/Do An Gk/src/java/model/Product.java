/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;
/*
 *
 * @author Van Khoa
 */
public class Product {
  private long productID;
     private long categoryID;
 private String productname;
  private String Img;
  private String detail;

    public Product(long productID, long categoryID, String productname, String Img, String detail) {
        this.productID = productID;
        this.categoryID = categoryID;
        this.productname = productname;
        this.Img = Img;
        this.detail = detail;
    }

    
    public Product() {
    }

    public Product(long maphim1) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    

    public long getProductID() {
        return productID;
    }

    public long getCategoryID() {
        return categoryID;
    }

    public String getProductname() {
        return productname;
    }

    public String getImg() {
        return Img;
    }

    public String getDetail() {
        return detail;
    }

    public void setProductID(long productID) {
        this.productID = productID;
    }

    public void setCategoryID(long categoryID) {
        this.categoryID = categoryID;
    }

    public void setProductname(String productname) {
        this.productname = productname;
    }

    public void setImg(String Img) {
        this.Img = Img;
    }

    public void setDetail(String detail) {
        this.detail = detail;
    }

}
