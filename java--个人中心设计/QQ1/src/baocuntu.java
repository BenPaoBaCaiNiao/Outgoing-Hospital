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
			FileInputStream fi=new FileInputStream("src/image/˵˵����.jpg");  
			pstmt.setBinaryStream(2,fi,fi.available());
			pstmt.setString(1, "�¶��ļ���");			
			pstmt.execute();  
			fi.close();  
			pstmt.close();  
			con.close(); 
			JOptionPane.showMessageDialog(null, "����ɹ�");
			}catch(Exception e){
					JOptionPane.showMessageDialog(null, "����ʧ��");
					}  
			}

	//public static void main(String[] args) {
		// TODO �Զ����ɵķ������
		//new baocuntu();

	//}
}
