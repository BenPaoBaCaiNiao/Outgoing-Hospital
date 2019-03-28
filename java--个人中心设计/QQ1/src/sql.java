import java.awt.Image;
import java.io.BufferedInputStream;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.sql.*;
import java.util.*;

import javax.imageio.*;
import javax.swing.*;

import com.lgq.utils.*;
public class sql {
	DBUtil db=new DBUtil();
	static Connection conn=null;
	String sql;
	ResultSet rs;
	PreparedStatement prestmt;
	
	public sql()
	{
		try
		{
		conn=db.getConnetion();
		}
		catch(Exception ex)
		{
			ex.printStackTrace();
		}		
		
	}
	public  boolean look(String sql,String name,String passwd) throws SQLException 
	{	
		boolean b=false;
		prestmt=conn.prepareStatement(sql);
		prestmt.setString(1,name);
		prestmt.setString(2,passwd);		
		rs=prestmt.executeQuery();
		if(rs.next())
		{
			b=true;
		}		
		return b;
	}
	
	public boolean add(String sql,String name,String passwd) throws SQLException
	{
		boolean b=false;
		int n=0;
		prestmt=conn.prepareStatement(sql);
		prestmt.setString(1,name);
		prestmt.setString(2,passwd);		
		n=prestmt.executeUpdate();
		if(n==1)
		{
			b=true;
		}
		return b;
		
	}
	//public boolean select(String sal,String no) throws SQLException
	//{
		//boolean b=false;
		//int n=0;
		//prestmt=conn.prepareStatement(sql);
		//prestmt.setString(1,no);
		//rs=prestmt.executeQuery();
		//if(rs.next())
		//{
			//b=true;
		//}		
		//return b;
	//}
	public void closeconn()
	{
		db.release(conn, prestmt, rs);
	}
	public boolean addpersonal(String sql,String no,String name,String age,String xingqu,String others) throws SQLException
	{
		boolean b=false;
		int n=0;
		prestmt=conn.prepareStatement(sql);		
		prestmt.setString(1,name);
		prestmt.setString(2, age);
		prestmt.setString(3, xingqu);
		prestmt.setString(4, others);
		prestmt.setString(5,no);
		n=prestmt.executeUpdate();
		if(n==1)
		{
			b=true;
		}
		return b;
	}
	public Vector selectpersonal(String sql,String No) throws SQLException
	{
		Vector information=new Vector(3,3);
		boolean b=false;
		prestmt=conn.prepareStatement(sql);
		prestmt.setString(1,No);
		rs=prestmt.executeQuery();
		if(rs.next())			
		{
			information.add(rs.getString(2));
			information.add(rs.getString(3));
			information.add(rs.getString(4)+rs.getString(5));
		}
		return information;
	}
	public boolean addshuoshuo(String sql,String No,String shuoshuo,String shijian) throws SQLException
	{
		boolean b=false;
		int n=0;
		prestmt=conn.prepareStatement(sql);
		prestmt.setString(1,No);
		prestmt.setString(2, shuoshuo);
		prestmt.setString(3, shijian);
		n=prestmt.executeUpdate();
		if(n==1)
		{
			b=true;
		}
		return b;
	}
	public Vector selectshuoshuo(String sql) throws SQLException
	{
		Vector shuoshuo=new Vector(2,2);
		prestmt=conn.prepareStatement(sql);
		rs=prestmt.executeQuery();
		while(rs.next())
		{
			shuoshuo.add(new cshuoshuo(rs.getString(2),rs.getString(3),rs.getString(5)));
		}
		return shuoshuo;
	}
	public boolean delete(String sql,String no) throws SQLException
	{
		boolean b=false;
		int n=0;
		prestmt=conn.prepareStatement(sql);
		prestmt.setString(1, no);
		n=prestmt.executeUpdate();
		if(n==1)
		{
			b=true;
		}
		return b;
	}
	public JLabel gettouxiang(String sql,String nicheng) throws ClassNotFoundException
	{
		ImageIcon imageicon;
		Image image =null;
		BufferedInputStream inputImage;
		JLabel jl=new JLabel();
		try{  
			prestmt=conn.prepareStatement(sql);
			prestmt.setString(1, nicheng);
			rs=prestmt.executeQuery();
			if(rs.next())
			{
				InputStream in = rs.getBinaryStream(3);  
				inputImage = new BufferedInputStream(in);					
		        image=ImageIO.read (inputImage) ;
		        image=image.getScaledInstance(50,50, Image.SCALE_DEFAULT);
		        imageicon=new ImageIcon(image);
		        jl.setIcon(imageicon);
		        inputImage.close () ;
			}
	        }catch (SQLException e) { 
	        e.printStackTrace () ;
	        }catch (IOException e) {
	        e.printStackTrace () ;
	        }
		return jl;
			 
		}
	public void cuntouxiang(String sql,String name,String touname)
	{
		try{ 
				prestmt=conn.prepareStatement(sql);
				prestmt.setString(1, name);
				FileInputStream fi=new FileInputStream(touname);  
				prestmt.setBinaryStream(2,fi,fi.available());		
				prestmt.execute();  
				fi.close();
				JOptionPane.showMessageDialog(null, "存入成功");
				}catch(Exception e){
						JOptionPane.showMessageDialog(null, "存入失败");
				}  
			}
	public Vector getnicheng(String sql) throws SQLException	
	{
		Vector nicheng=new Vector(5,5);
		prestmt=conn.prepareStatement(sql);
		rs=prestmt.executeQuery();
		while(rs.next())
		{
			nicheng.add(rs.getString(2));
		}
		return nicheng;
		
	}
}


class cshuoshuo
{
	String content;
	String time;
	String name;
	public cshuoshuo(String content,String time,String name)
	{
		this.content=content;
		this.time=time;
		this.name=name;
	}
	public String getcontent()
	{
		return this.content;
	}
	public String gettime()
	{
		return this.time;
	}
	public String getname()
	{
		return this.name;
	}
}

