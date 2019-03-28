import com.lgq.utils.*;

import java.sql.*;  
import java.io.*; 

import javax.swing.JOptionPane;
public class baocuntu {
	public baocuntu()
	{
		try{  
			DBUtil db=new DBUtil();
			Connection con=db.getConnetion();
			String sql = "insert into tb_friends(Name,content) values (?,?)";  
			PreparedStatement pstmt=con.prepareStatement(sql);  
			FileInputStream fi=new FileInputStream("src/image/说说背景.jpg");  
			pstmt.setBinaryStream(2,fi,fi.available());
			pstmt.setString(1, "孤独的吉他");			
			pstmt.execute();  
			fi.close();  
			pstmt.close();  
			con.close(); 
			JOptionPane.showMessageDialog(null, "存入成功");
			}catch(Exception e){
					JOptionPane.showMessageDialog(null, "存入失败");
					}  
			}

	//public static void main(String[] args) {
		// TODO 自动生成的方法存根
		//new baocuntu();

	//}
}
