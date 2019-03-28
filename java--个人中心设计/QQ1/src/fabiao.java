import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;
import java.text.*;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextArea;

import java.util.Date;


public class fabiao extends JFrame implements ActionListener{
		JPanel jfabiao=new JPanel();
		JTextArea content;
		JButton queding;
		JLabel title=new JLabel("请输入内容：");
		String no;
		String time;
		public fabiao(String no)
		{
			super("说说发表");
			Date date=new Date();
			DateFormat format=new SimpleDateFormat("yyyy-MM-dd");
			time=format.format(date);
			this.no=no;
			title.setForeground(Color.white);
			title.setBounds(20, 20, 200, 30);
			content=new JTextArea(4,3);
			content.setBackground(Color.white);
			content.setBounds(20, 60, 600, 300);
			queding=new JButton("发表");
			queding.setBounds(20,400, 80,30);
			queding.setBackground(Color.blue);
			queding.addActionListener(this);
			jfabiao.setLayout(null);
			jfabiao.add(title);
			jfabiao.add(content);
			jfabiao.add(queding);
			jfabiao.setBackground(Color.black );
			jfabiao.setBounds(50,110,600,400);
			this.add(jfabiao);
			this.setBounds(400,80,650,500);
			this.setVisible(true);
			
		}
		public void actionPerformed(ActionEvent e)
		{
			if(e.getSource()==queding)
			{
				sql s=new sql();
				boolean b=false;
				String sql=new String("insert tb_shuoshuo(No,shuoshuo,shijian) values(?,?,?);");
				try {
					b=s.addshuoshuo(sql,no,content.getText(),time);
				} catch (SQLException e1) {
					// TODO 自动生成的 catch 块
					e1.printStackTrace();
				}	
				if(b)
				{
					JOptionPane.showMessageDialog(null, "发表成功");
					content.setText(null);
				}
			}
		}
	}

