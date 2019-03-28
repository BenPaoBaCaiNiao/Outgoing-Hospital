import java.awt.*;
import java.awt.event.*;
import java.sql.SQLException;

import makephoto.*;

import javax.swing.*;
public class personal  extends JFrame implements ItemListener{
			String age,xingqu;
			JFrame jf=new JFrame();
			JLabel label[]={new JLabel("昵称"),new JLabel("年龄段："),new JLabel("兴趣爱好 ："),new JLabel("其他：")};
			JRadioButton jrage[]={new JRadioButton("5-15岁"),new JRadioButton("16-25岁"),new JRadioButton("26-35岁"),new JRadioButton("36-45岁"),new JRadioButton("46-55岁")};
			JCheckBox jcxingqu[]={new JCheckBox("上网聊天/交友"),new JCheckBox("体育/户外健身"),new JCheckBox("汽车/购物"),new JCheckBox("旅游/度假"),new JCheckBox("时尚服装/化妆品")};
			JButton jb[]={new JButton("提交"),new JButton("清空"),new JButton("退出")};
			JTextArea others;
			JTextField name=new JTextField(200);
			ButtonGroup bg=new ButtonGroup();
			JPanel jp,jpanel;
			String no;
			sql s=new sql();
			boolean b=false;
			Container con=jf.getContentPane();
			public personal(String No)
			{
				this.no=No;
				jpanel=new JPanel();
				jp=new JPanel();
				jp.setLayout(null);
				name.setBounds(30, 50,200,30);
				jp.add(name);
				for(int i=0;i<4;i++)
				{
					label[i].setBounds(30,20+i*80,80,30);
					jp.add(label[i]);
				}
				for(int i=0;i<5;i++)
				{
					jrage[i].setBounds(40+i*100,150,80,30); 			
					jrage[i].addItemListener(this);
					bg.add(jrage[i]);
					jcxingqu[i].setBounds(40+i*120,220,120,30);
					jcxingqu[i].addItemListener(this);
					jp.add(jrage[i]);
					jp.add(jcxingqu[i]);
								
				}
				for(int i=0;i<3;i++)
				{
					jb[i].setBounds(450+i*100,550,70,30);
					jp.add(jb[i]);
				}
			
				others=new JTextArea(4,4);
				others.setBounds(30, 300, 500,200);
				jp.add(others);
				jb[0].addActionListener(new ActionListener()
				{
					public void actionPerformed(ActionEvent event)
					{
						int n=JOptionPane.showConfirmDialog(null,"个人信息："+"  昵称："+name.getText()+"  年龄为："+age+"  兴趣为："+xingqu+"  是否提交？","提示",JOptionPane.YES_NO_OPTION);
						if(n==JOptionPane.YES_OPTION)
						{
							
							boolean b=false;
							String sql=new String();
							if(jb[0].getText()=="提交")
							{
								sql="insert tb_personal(Name,Age,Xinqu,others,No) values(?,?,?,?,?);";
								try {
									b=s.addpersonal(sql,no, name.getText(),age,xingqu,others.getText());
								} catch (SQLException e) {
									// TODO 自动生成的 catch 块
									e.printStackTrace();
								}
								jb[0].setText("更改");
								jb[2].setText("去主页");
							if(b)
								{
									JOptionPane.showMessageDialog(jpanel, "提交成功","提示",JOptionPane.WARNING_MESSAGE);
								}			
							}
							else if(jb[0].getText()=="更改")
							{
								sql="update tb_personal set Name=?,Age=?,Xinqu=?,others=? where No=?;";
								try {
									b=s.addpersonal(sql, no, name.getText(), age, xingqu, others.getText());
								} catch (SQLException e) {
									// TODO 自动生成的 catch 块
									e.printStackTrace();
								}	
								if(b)
								{
									JOptionPane.showMessageDialog(jpanel, "更改成功","提示",JOptionPane.WARNING_MESSAGE);
								}						
							}
													
						} 	
						s.closeconn();
					}
				});
				jb[1].addActionListener(new ActionListener()
				{
					public void actionPerformed(ActionEvent event)
					{
						bg.clearSelection();
						for(int i=0;i<5;i++){
							jcxingqu[i].setSelected(false);
						}
						
					}
				});	
				jb[2].addActionListener(new ActionListener()
				{
					public void actionPerformed(ActionEvent event)
					{	
						if(jb[2].getText()=="去主页")
						{
							jf.setVisible(false);
							new zhuye(no);
						}
						else if(jb[2].getText()=="退出")
						{
							jf.setVisible(false);
						}
				
					}
				});	
				
				con.add(jp);
				jf.setBounds(200,50,750,700);
				jf.setVisible(true);
				jf.setTitle("个人信息填写");
				
			}
			public void itemStateChanged(ItemEvent e)
			{
				
				age=new String();
				xingqu=new String();
				for(int i=0;i<5;i++)
				{
					
				if(jrage[i].isSelected())
				{
					age+=jrage[i].getText();
				}
			    if(jcxingqu[i].isSelected())
				{
					xingqu+=jcxingqu[i].getText();
				}
				}
				
			}
			public void setText()
			{
				jb[0].setText("更改");
			}
			
			
				
		}
