import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.SQLException;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;


public 	class denglu extends JFrame implements ActionListener
	{

			/**
			 * @param args
			 */
			JLabel name=new JLabel("�û�����");
			JLabel passwrd=new JLabel("���룺");
			JTextField nametext=new JTextField(20);
			JPasswordField passwrdtext=new JPasswordField(20);
			JButton but1=new JButton("��¼");
			JButton but2=new JButton("ȡ��");
			JButton but3=new JButton("ע��");
			JPanel jp1=new JPanel();
			JPanel jp2=new JPanel();
			JPanel jp3=new JPanel();
			JPanel jp=new JPanel();
			
			public denglu()
			{
				jp.setLayout(new FlowLayout());
				name.setBounds(20,10,40,40);
				jp1.add(name);
				jp1.add(nametext);
				jp.add(jp1);
				jp2.add(passwrd);
				jp2.add(passwrdtext);
				jp.add(jp2);
				but1.addActionListener(this);
				but2.addActionListener(this);
				but3.addActionListener(this);
				jp3.add(but1);
				jp3.add(but2);
				jp3.add(but3);
				jp.add(jp3);			
				this.add(jp);
				this.setVisible(true);
				this.setTitle("��¼");
				this.setBounds(100,100,350,200);
				this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
				
			}

			public void actionPerformed(ActionEvent e)
			{
				String name;
				String passwrd;
				name=new String(nametext.getText().trim());
				passwrd=new String(passwrdtext.getPassword());
				if(e.getSource()==but1)
				{
					sql s=new sql();
					boolean b=false;
					String sql="select * from tb_denglu where Name=? and Password=?;";					
					try {
						b=s.look(sql,name,passwrd);
					} catch (SQLException e1) {
						// TODO �Զ����ɵ� catch ��
						e1.printStackTrace();
					}
					s.closeconn();
					if(b)
					{		
						int n=JOptionPane.showConfirmDialog(this, "��¼�ɹ����Ƿ���ȥ���Ƹ�����Ϣ��", "��ʾ", JOptionPane.YES_NO_OPTION);
						if(n==JOptionPane.YES_OPTION)
						{						
						  new personal(name);
						 this.setVisible(false);
						}
						else
						{
							this.setVisible(false);
							zhuye zhuye=new zhuye(name);
						}
					}
					else
					{
						JOptionPane.showMessageDialog(null, "���û�������,�����µ�¼");
					}
						
				}
				if(e.getSource()==but2)
				{
					passwrdtext.setText("");
					System.exit(0);
				}
				if(e.getSource()==but3)
				{
					this.setVisible(false);
					new zhuce();
				}
			}		
			

		    
				
		}


