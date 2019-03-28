import java.awt.*;
import java.awt.event.*;
import java.sql.SQLException;
import java.util.*;
import javax.swing.*;
import makephoto.*;
public class kanshuoshuo extends JFrame implements ActionListener{
		JTextArea shuoshuo;
		JScrollPane js;		
		JButton jb[]={new JButton("刷新"),new JButton("退出")};
		JPanel jp=new JPanel();		
		String no;
		Vector vshuo;
		public kanshuoshuo(String no)
		{		
			super("说说内容");
			this.no=no;
			Container con=this.getContentPane();
			shuoshuo=new shuobj("src/image/绿叶.jpg");
			js=new JScrollPane(shuoshuo);
			shuoshuo.setLineWrap(true);
			shuoshuo.setFont(new Font("宋体", Font.PLAIN, 30));
			shuoshuo.setEditable(false);
			jp.setLayout(new FlowLayout());
			for(int i=0;i<2;i++)
			{
				jb[i].addActionListener(this);
				jp.add(jb[i]);				
			}
			showshuo();
			con.add(js,BorderLayout.CENTER);
			con.add(jp,BorderLayout.SOUTH);
			this.setBounds(200,100, 800, 600);
			this.setVisible(true);
			this.add(con);
		}
		public void actionPerformed(ActionEvent e)
		{
			if(e.getSource()==jb[0])
			{
				shuoshuo.setText(null);
				showshuo();
			}
			if(e.getSource()==jb[1])
			{
				this.setVisible(false);
			}
		}
		public void showshuo()
		{
			sql s=new sql();
			try {
				vshuo=s.selectshuoshuo("select * from tb_shuoshuo ss join tb_personal p on ss.No=p.No;");
			} catch (SQLException e) {
				// TODO 自动生成的 catch 块
				e.printStackTrace();
			}
			for(int i=0;i<vshuo.size();i++)
			{
				cshuoshuo cshuo=(cshuoshuo)vshuo.get(i);
				shuoshuo.append(cshuo.getname()+"\n");
				shuoshuo.append(cshuo.gettime()+"\n");
				shuoshuo.append(cshuo.getcontent()+"\n");
				shuoshuo.append("\n");
			}
			s.closeconn();
		}
	
	}


