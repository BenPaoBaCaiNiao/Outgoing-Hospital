import java.applet.Applet;
import java.applet.AudioClip;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import java.io.File;
import java.net.*;

import javax.swing.*;
public class shengyin extends Applet implements ActionListener,ItemListener {
	  AudioClip ac;
      Button button_play,button_loop,button_stop;
      String mname="那个男孩";
      JComboBox cbmusic=new JComboBox();
      Label title=new Label("请选择音乐");
      JButton ok=new JButton("确定");
      JPanel jp=new JPanel();
      public void init ()  {
      
      add(title);   
       title.setBounds(100, 100, 100, 30);
       cbmusic.addItem("那个男孩");
       cbmusic.addItem("像风一样");
       cbmusic.setVisible(true);   
       cbmusic.setSize(300,30);
       cbmusic.setBounds(60, 40, 250, 30);
       cbmusic.addItemListener(this);
       add(cbmusic);
       add(ok);
       ok.setBounds(320, 40, 70, 30);
       ok.addActionListener(this);   
 
       Label label= new Label ("音乐载入成功!点击按钮开始播放!") ;
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
       jp.setBounds(60, 80, 250, 300);
       jp.setVisible(false);
       add(jp);
       setLayout(null);
       setSize(400,300);
      }
public void actionPerformed (ActionEvent e){ // 实现监听器方法
     if (e.getSource () == button_play) {

     ac.play();// 开始播放
     }else if (e.getSource () == button_loop) {

     ac.loop();// 循环播放
     }
     if (e.getSource ()== button_stop) {

     ac.stop();// 停止播放
   }
     if(e.getSource()==ok)
     {
    	 ac=this.getAudioClip(this.getCodeBase(), "music/"+this.mname+".wav");
    	 jp.setVisible(true);
     }
     
  }
public void itemStateChanged(ItemEvent e)
{
		 if(e.getStateChange()==ItemEvent.SELECTED)
		 {
			 this.mname=(String)cbmusic.getSelectedItem();
		 }
}


}
