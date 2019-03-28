import java.applet.Applet;
import java.applet.AudioClip;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.net.MalformedURLException;
import java.net.URL;

import javax.swing.*;

import makephoto.*;


public 	class yinyue extends JFrame implements ActionListener,ItemListener {
	  AudioClip ac;
	  Boolean b=true;
	  URL url;
      Button button_play,button_loop,button_stop;
      String mname="那个男孩";
      JComboBox cbmusic=new JComboBox();
      Label title=new Label("请选择音乐");
      JButton ok=new JButton("确定");
      JPanel jp=new JPanel();
      Label label= new Label () ;
      public yinyue ()  { 
      super("背景音乐设置");     
       Container con=this.getContentPane();
       con.add(title); 
       title.setBounds(60, 10, 150, 30);
       title.setBackground(Color.black);
       title.setForeground(Color.white);
       title.setFont(new Font("宋体", Font.PLAIN, 30));
       cbmusic.addItem("那个男孩");
       cbmusic.addItem("像风一样");
       cbmusic.setVisible(true);   
       cbmusic.setSize(300,30);
       cbmusic.setBounds(230, 10, 250, 30);
       cbmusic.addItemListener(this);
       con.add(cbmusic);
       con.add(ok);
       ok.setBounds(490, 10, 70, 30);
       ok.addActionListener(this);       
       jp.add(label) ;
       button_play= new Button ("开始播放") ;// 添加按钮控制
       button_loop= new Button ("循环播放") ;
       button_stop= new Button ("停止播放") ;
       button_play.addActionListener (this) ;// 按钮添加事件监听器
       button_stop.addActionListener (this) ;
       button_loop.addActionListener (this) ;
       jp.add (button_play) ;
       jp.add (button_loop) ;
       jp.add (button_stop) ;
       jp.setSize(100,100);
       jp.setBounds(60, 50, 250, 70);
       jp.setVisible(false);
       con.add(jp);
       makephoto m=new makephoto();
       m.makebeijign(this, con, "src/image/音乐.jpg");       
       setLayout(null);
       setBounds(200,10,1000,800);
       setVisible(true);
      }
public void actionPerformed (ActionEvent e){ // 实现监听器方法
     if (e.getSource () == button_play) {
    	 
    	 if(b==false)
    	 {
    		 int n=JOptionPane.showConfirmDialog(null, "是否先停止前一首歌的播放?", "提示",JOptionPane.YES_NO_CANCEL_OPTION);
    				 if(n==JOptionPane.YES_OPTION)
    				 {
		    			 this.ac.stop(); 
		    			 b=true;
		    			 JOptionPane.showMessageDialog(null, "请重新播放");
    				 }
    	 }
    	 else
    	 {

    	 this. ac= JApplet.newAudioClip(url);
    	 ac.play();
    	 b=false;
    	 }
     
     }else if (e.getSource () == button_loop) {

     this.ac.loop();// 循环播放
     }
     if (e.getSource ()== button_stop) {

     this.ac.stop();// 停止播放
     b=true;
   }
     if(e.getSource()==ok)
     {
    	 jp.setVisible(true);
    	 this. ac= JApplet.newAudioClip(url);    	 
     }
     
  }
public void itemStateChanged(ItemEvent e)
{ 
		 if(e.getStateChange()==ItemEvent.SELECTED)
		 {
			 this.mname=(String)cbmusic.getSelectedItem();
			 
			 try
			 {			
			 File f = new File("C:\\Users\\Administrator\\Desktop\\java--QQ个人空间\\QQ1\\src\\music\\"+this.mname+".wav"); //引号里面的是音乐文件所在的绝对鹿筋
			 this.label.setText("音乐载入成功!点击按钮开始播放!");
			 this.url = f.toURL(); 			
			 }catch (MalformedURLException e1) { 
				 e1.printStackTrace(); 
			 } 
			 //url = getClass ().getResource(this.mname+".wav"); 
		 }
}
}
