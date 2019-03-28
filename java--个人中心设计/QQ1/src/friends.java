import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.Font;
import java.awt.Image;
import java.sql.SQLException;
import java.util.*;
import javax.swing.*;


public class friends extends JFrame {
	JLabel[] jl,jnicheng;
	JLabel title=new JLabel("好友列表");
	sql s=new sql();
	Container con;
	public friends()
	{
		super("通讯录");
		con=this.getContentPane();
		Vector nicheng=new Vector(5,5);
		try {
			nicheng = s.getnicheng("select * from tb_friends;");
		} catch (SQLException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}
		int n=nicheng.size();
		title.setFont(new Font("宋体", Font.PLAIN, 30));
		jl=new JLabel[n];
		jnicheng=new JLabel[n];
		for(int i=0;i<nicheng.size();i++)
		{
			try {
				jl[i]=s.gettouxiang("select * from tb_friends where Name=?;",(String)nicheng.get(i));
			} catch (ClassNotFoundException e) {
				// TODO 自动生成的 catch 块
				e.printStackTrace();
			}
			String name=(String)nicheng.get(i);
			jnicheng[i]=new JLabel(name);
			jnicheng[i].setFont(new Font("宋体", Font.PLAIN, 30));
			
		}
		for(int i=0;i<n;i++)
		{
			jl[i].setBounds(30, 50+i*100, 50, 50);			
			this.add(jl[i]);
			jnicheng[i].setBounds(100, 50+i*100,300,50);			
			this.add(jnicheng[i]);
		}
		con.add(title,BorderLayout.NORTH);
		this.setVisible(true);
		this.setBounds(400, 20, 400, 700);		
		
	}

}
