import java.awt.Container;
import java.awt.GridLayout;
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


public class zhuce extends JFrame implements ActionListener	{
		JTextField nameTextField;
		JPasswordField passwordTextField;
		JPasswordField conpassword;
		JButton okButton;
		JButton exitButton;
		public zhuce()
		{
			super("ע��");
			JLabel name=new JLabel("�û���");
			JLabel password=new JLabel("����");
			JLabel password2=new JLabel("ȷ������");
			okButton=new JButton("OK");
			exitButton=new JButton("EXIT");
			okButton.addActionListener(this);
			exitButton.addActionListener(this);
			nameTextField=new JTextField(15);
			passwordTextField=new JPasswordField(10);
			conpassword=new JPasswordField(10);
			JPanel NamePanel=new JPanel();
			NamePanel.add(name);
			NamePanel.add(nameTextField);
			JPanel passwordPanel1=new JPanel();
			passwordPanel1.add(password);
			passwordPanel1.add(passwordTextField);
			JPanel passwordPanel2=new JPanel();
			passwordPanel2.add(password2);
			passwordPanel2.add(conpassword);
			JPanel buttonPanel=new JPanel();
			buttonPanel.add(okButton);
			buttonPanel.add(exitButton);
			Container container=this.getContentPane();
			container.setLayout(new GridLayout(4,1));
			container.add(NamePanel);
			container.add(passwordPanel1);
			container.add(passwordPanel2);
			container.add(buttonPanel);
			setSize(325,225);
			setVisible(true);
			
			
		}
		public void actionPerformed(ActionEvent e)
		{
			if(e.getSource()==okButton)
			{
				validateDate();
			}
			if(e.getSource()==exitButton)
			{
				this.setVisible(false);	
				new denglu();
			}
		}
		private void validateDate()
		{
			if(nameTextField.getText().equals("") || passwordTextField.getPassword().equals("") || conpassword.getPassword().equals(""))
			{
				JOptionPane.showMessageDialog(this,"��������Ϣ");
				
			}
			else if(!nameTextField.getText().matches("[a-zA-Z][a-zA-Z0-9]*"))
			{
				JOptionPane.showMessageDialog(this, "�û�����������ĸ��ͷ");
			}
			else if(nameTextField.getText().length()>15)
				JOptionPane.showMessageDialog(this,"�û������ɳ���15��");
			else if(passwordTextField.getPassword().length<4)
				JOptionPane.showMessageDialog(this,"���볤�ȹ��̣�4�����ϣ�");
			else if(!validatePassword())
				JOptionPane.showMessageDialog(this,"�������������ּ���ĸ");
			else if(!compareTwoPassword())
				JOptionPane.showMessageDialog(this, "ǰ���������벻һ��");
			else
			{
				sql s=new sql();
				boolean b=false;
				String asql=new String("insert tb_denglu(Name,Password) values(?,?);");
				String ssql=new String("select * from tb_denglu where Name=? and Password=?;");
				String name=new String(nameTextField.getText());
				String passwrd=new String(passwordTextField.getPassword());
				try {
					b=s.look(ssql,name,passwrd);
				} catch (SQLException e) {
					// TODO �Զ����ɵ� catch ��
					e.printStackTrace();
				}
				if(b)
				{
					JOptionPane.showMessageDialog(null, "���û��Ѵ��ڣ�������ע��");
				}
				else
				{
					try {
						b=s.add(asql,name,passwrd);
					} catch (SQLException e) {
						// TODO �Զ����ɵ� catch ��
						e.printStackTrace();
					}
					if(b)
					{
						int n=JOptionPane.showConfirmDialog(this,"ע��ɹ�,�Ƿ�ȥ��¼��","��ʾ",JOptionPane.YES_NO_OPTION);
						if(n==JOptionPane.YES_OPTION)
						{
							s.closeconn();
							new denglu();
							this.setVisible(false);
						}
					}
				}			
						
			}
		}
		private boolean validatePassword()
		{
			boolean b=false;
			String password=new String(passwordTextField.getPassword());
			b=password.matches("[a-zA-Z]+[0-9]+");
			return b;
		}
		private boolean compareTwoPassword()
		{
			boolean b=false;
			String password1=new String(passwordTextField.getPassword());
			String password2=new String(conpassword.getPassword());
			if(password1.equals(password2))
				b=true;
			return b;			
		}

	}



