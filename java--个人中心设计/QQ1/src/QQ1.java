import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.sql.SQLException;
import java.util.*;
import javax.swing.*;
import lookphoto.*;
import chatRoom.*;
import makephoto.*;
public class QQ1{
	public static void main(String[] args) {
		// TODO 自动生成的方法存根
		new denglu();

	}
}

class zhuye extends JFrame implements ActionListener
{	
	private JMenuBar mb=new JMenuBar();
	private JMenu mm=new JMenu("设置");
	private JMenu mm2=new JMenu("个人工具");
	private JMenu mm3=new JMenu("说说");
	private JMenu mtongxunlu=new JMenu("通讯录");
	private JMenuItem fabiao=new JMenuItem("发表说说");
	private JMenuItem kanshuoshuo=new JMenuItem("查看说说");
	private JMenuItem mi1=new JMenuItem("背景音乐");
	private JMenuItem mi2=new JMenuItem("浏览背景图片");
	JMenuItem mi5=new JMenuItem("确定更换背景");
	JMenuItem mi3=new JMenuItem("计算器");
	JMenuItem mi4=new JMenuItem("新建文件");
	JMenuItem kantongxunlu=new JMenuItem("查看通讯录");

	JLabel touxiang=new JLabel();
	JLabel name=new JLabel();
	ImageIcon image;
	Image img;
	JLabel imgLabel = new JLabel();
	public String filename;
	JPanel jp=new JPanel();
	JButton changebut=new JButton("更改个人信息");
	JButton shuaxin=new JButton("刷新");
	JLabel age,xingqu,title;
	JTextField tage=new JTextField(20);
	JTextArea txingqu=new JTextArea(4,4);
	String no;
	Vector information=new Vector(3,3);
	Container cp=this.getContentPane();
	public zhuye(String No)
	{	
		super("个人中心");
		this.no=No;			
		name.setBounds(110, 50,500,30);
		title=new JLabel("个人信息");
		title.setBounds(20, 20, 200, 20);
		age=new JLabel("年龄");
		age.setBounds(20, 60, 100, 30);
		tage.setBounds(20, 100, 200, 30);
		tage.setEditable(false);
		xingqu=new JLabel("兴趣");
		xingqu.setBounds(20,140,60,30);
		txingqu.setBounds(20, 180, 200, 200);
		txingqu.setEditable(false);
		sql s=new sql();
		try {
			information=s.selectpersonal("select * from tb_personal where No=?",no);
		} catch (SQLException e1) {
			// TODO 自动生成的 catch 块
			e1.printStackTrace();
		}
		name.setText((String) information.get(0));
		tage.setText((String)information.get(1));		
		txingqu.setText((String)information.get(2));
		s.closeconn();
        changebut.setBounds(100,400,100,50);
        shuaxin.setBounds(0, 400, 100, 50);
        shuaxin.setEnabled(false);
        shuaxin.addActionListener(this);
		changebut.addActionListener(this);
		makephone("src/image/头像.jpg",0);
		touxiang.setBounds(50, 50, 50, 50);		
		//touxiang.addMouseListener(new MouseAdapter(){
		     //public void MouseClicked(MouseEvent e){
		    	// int n=JOptionPane.showConfirmDialog(null, "确定更换头像","提示", JOptionPane.YES_NO_OPTION);
		    	 //if(n==JOptionPane.YES_OPTION)
		    	// {
		    		//new shangchuan();
		    	// }		         
		       // }
		//});				
		mm.add(mi1);
		mm.add(mi2);
		mm.add(mi5);
		mb.add(mm);
		mtongxunlu.add(kantongxunlu);
		mb.add(mtongxunlu);
		mm2.add(mi3);
		mm2.add(mi4);
		mb.add(mm2);
		mm3.add(fabiao);
		mm3.add(kanshuoshuo);
		mb.add(mm3);				
		mi1.addActionListener(this);
		mi2.addActionListener(this);
		mi3.addActionListener(this);
		mi4.addActionListener(this);
		kantongxunlu.addActionListener(this);
		fabiao.addActionListener(this);	
		kanshuoshuo.addActionListener(this);
		makephone("src/image/49.jpg",1);
		//beijing("src/image/49.jpg");
		cp.setLayout(new BorderLayout());	
		((JPanel)cp).setOpaque(false); //注意这里，将内容面板设为透明。这样LayeredPane面板中的背景才能显示出来
		
		jp.setLayout(null);
		jp.setBounds(50,110,300,800);
		jp.add(title);
		jp.add(age);
		jp.add(tage);
		jp.add(xingqu);
		jp.add(txingqu);
		jp.add(changebut);
		jp.add(shuaxin);
		cp.add(jp);
		cp.add(touxiang);
		cp.add(name);//主页设计		
		this.setLayout(null);
		this.setExtendedState( Frame.MAXIMIZED_BOTH );
		this.setJMenuBar(mb);
		this.setVisible(true);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		
	}
	public void makephone(String filename,int i)
	{	
		int width=50,height=50;
		this.image=new ImageIcon(filename);		
		img=image.getImage();
							
		if(i==0)
		{
		img = img.getScaledInstance(width, height, Image.SCALE_DEFAULT);				
		image.setImage(img);		
		this.touxiang.setIcon(image);		
					
		}
		else
		{
			image.setImage(img);
			JLabel imgLabel = new JLabel(image);//将背景图放在标签里
			this.getLayeredPane().add(imgLabel, new Integer(Integer.MIN_VALUE));//注意这里是关键，将背景标签添加到jfram的LayeredPane面板里
			imgLabel.setBounds(0,0,image.getIconWidth(), image.getIconHeight());//设置背景标签的位置
		}	
		
	}
	//public void beijing(String path)
	//{
		//this.path=path;
		//ImageIcon img = new ImageIcon(path);//这是背景图片
		//JLabel imgLabel = new JLabel(img);//将背景图放在标签里
		//this.getLayeredPane().add(imgLabel, new Integer(Integer.MIN_VALUE));//注意这里是关键，将背景标签添加到jfram的LayeredPane面板里
		//imgLabel.setBounds(0,0,img.getIconWidth(), img.getIconHeight());//设置背景标签的位置					
	//}
	public void setname(String filename)
	{
		this.name.setText(filename);
	}
		

	public void actionPerformed(ActionEvent e)
	{
		
		String filename=null;
		if(e.getSource()==mi4)
			new createfile();
		if(e.getSource()==mi1)
		{
			new yinyue();
		}
		if(e.getSource()==mi2)
		{
			shangchuan check=new shangchuan();			
		}
		if(e.getSource()==mi5)
		{
			shangchuan check1=new shangchuan(1);
			filename=check1.getfilename();
			if(filename!="")
			{
				makephoto m=new makephoto();
				m.makebeijign(this, cp, filename);
			}
			else
			{
				JOptionPane.showMessageDialog(null, "更换失败");
			}
		}
	
		if(e.getSource()==mi3)
			new jisuanqi();
		if(e.getSource()==fabiao)
			new fabiao(no);
		if(e.getSource()==kanshuoshuo)
		{
			new kanshuoshuo(no);
		}
			
		if(e.getSource()==kantongxunlu)
		{
			new friends();
		}
		if(e.getSource()==changebut)
		{
			personal p=new personal(no);
			p.setText();
			shuaxin.setEnabled(true);
		}
		if(e.getSource()==shuaxin)
		{
			sql s=new sql();
			Vector inform=new Vector(3,3);
			try {
				inform=s.selectpersonal("select * from tb_personal where No=?",no);
			} catch (SQLException e1) {
				// TODO 自动生成的 catch 块
				e1.printStackTrace();
			}
			name.setText((String) inform.get(0));
			tage.setText((String)inform.get(1));		
			txingqu.setText((String)inform.get(2));
			s.closeconn();
		}

	}

}		
	
class ImagePanel extends JPanel
{
	JLabel jl=new JLabel();
	ImageIcon image;
	Image img;
	int width;
	int height;
	public void loadImage(String filename)	
	{			
	
		width=600;
		height=600;		
		jl.setSize(width,height);
		this.image=new ImageIcon(filename);
		img=image.getImage();
		img = img.getScaledInstance(width, height, Image.SCALE_DEFAULT);
		image.setImage(img);
		this.jl.setIcon(image);
		this.add(jl);
		this.setVisible(true);
	}	
		
}
//class Friend extends JPanel
//{
	//JScrollPane jspane=new JScrollPane();
	
	
//}





