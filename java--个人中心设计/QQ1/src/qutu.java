
import java.awt.*;  
import java.applet.*;  
import java.awt.image.*;  

import javax.imageio.*;
import javax.swing.*; 

import java.sql.*;  
import java.io.*;

import com.lgq.utils.*;
public class qutu{
	JFrame f=new JFrame();
	JLabel label=new JLabel();
	ImageIcon imageicon;
	BufferedInputStream inputImage;
	public qutu() {		
		try{  
		DBUtil db=new DBUtil();
		Connection con=db.getConnetion();
		Statement stmt=con.createStatement();  
		String sql = "select * from tb_friends where Name='音乐傻子';";  
		ResultSet rs=stmt.executeQuery(sql);  
		if(rs.next())
		{
			InputStream in = rs.getBinaryStream(3);  
			inputImage = new BufferedInputStream(in);			
			Image image =null;
	        image=ImageIO.read (inputImage) ;
	        image=image.getScaledInstance(50,50, Image.SCALE_DEFAULT);
	        imageicon=new ImageIcon(image);
	        label.setIcon(imageicon);
	        inputImage.close () ;
		}			
        rs.close();  
		con.close();
        }catch (SQLException e) { 
        e.printStackTrace () ;
        }catch (IOException e) {
        e.printStackTrace () ;
        } catch (ClassNotFoundException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}
		label.setBounds(200, 200, 100, 100);
		f.add(label);
		f.setSize(535,400);  
		f.setVisible(true);  
		 
		}

         
	//public static void main(String[] args) {
		// TODO 自动生成的方法存根
		//new qutu();

	//}

}
