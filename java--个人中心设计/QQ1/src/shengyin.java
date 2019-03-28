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
      String mname="�Ǹ��к�";
      JComboBox cbmusic=new JComboBox();
      Label title=new Label("��ѡ������");
      JButton ok=new JButton("ȷ��");
      JPanel jp=new JPanel();
      public void init ()  {
      
      add(title);   
       title.setBounds(100, 100, 100, 30);
       cbmusic.addItem("�Ǹ��к�");
       cbmusic.addItem("���һ��");
       cbmusic.setVisible(true);   
       cbmusic.setSize(300,30);
       cbmusic.setBounds(60, 40, 250, 30);
       cbmusic.addItemListener(this);
       add(cbmusic);
       add(ok);
       ok.setBounds(320, 40, 70, 30);
       ok.addActionListener(this);   
 
       Label label= new Label ("��������ɹ�!�����ť��ʼ����!") ;
       jp.add(label) ;
       button_play= new Button ("��ʼ����") ;// ��Ӱ�ť����
       button_loop= new Button ("ѭ������") ;
       button_stop= new Button ("ֹͣ����") ;
       button_play.addActionListener (this) ;// ��ť����¼�������
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
public void actionPerformed (ActionEvent e){ // ʵ�ּ���������
     if (e.getSource () == button_play) {

     ac.play();// ��ʼ����
     }else if (e.getSource () == button_loop) {

     ac.loop();// ѭ������
     }
     if (e.getSource ()== button_stop) {

     ac.stop();// ֹͣ����
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
