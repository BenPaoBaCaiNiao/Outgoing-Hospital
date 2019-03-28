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
			super("注册");
			JLabel name=new JLabel("用户名");
			JLabel password=new JLabel("密码");
			JLabel password2=new JLabel("确认密码");
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
				JOptionPane.showMessageDialog(this,"请输入信息");
				
			}
			else if(!nameTextField.getText().matches("[a-zA-Z][a-zA-Z0-9]*"))
			{
				JOptionPane.showMessageDialog(this, "用户名必须以字母开头");
			}
			else if(nameTextField.getText().length()>15)
				JOptionPane.showMessageDialog(this,"用户名不可超过15个");
			else if(passwordTextField.getPassword().length<4)
				JOptionPane.showMessageDialog(this,"密码长度过短（4个以上）");
			else if(!validatePassword())
				JOptionPane.showMessageDialog(this,"密码必须包含数字及字母");
			else if(!compareTwoPassword())
				JOptionPane.showMessageDialog(this, "前后密码输入不一致");
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
					// TODO 自动生成的 catch 块
					e.printStackTrace();
				}
				if(b)
				{
					JOptionPane.showMessageDialog(null, "该用户已存在，请重新注册");
				}
				else
				{
					try {
						b=s.add(asql,name,passwrd);
					} catch (SQLException e) {
						// TODO 自动生成的 catch 块
						e.printStackTrace();
					}
					if(b)
					{
						int n=JOptionPane.showConfirmDialog(this,"注册成功,是否去登录？","提示",JOptionPane.YES_NO_OPTION);
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



