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
      String mname="�Ǹ��к�";
      JComboBox cbmusic=new JComboBox();
      Label title=new Label("��ѡ������");
      JButton ok=new JButton("ȷ��");
      JPanel jp=new JPanel();
      Label label= new Label () ;
      public yinyue ()  { 
      super("������������");     
       Container con=this.getContentPane();
       con.add(title); 
       title.setBounds(60, 10, 150, 30);
       title.setBackground(Color.black);
       title.setForeground(Color.white);
       title.setFont(new Font("����", Font.PLAIN, 30));
       cbmusic.addItem("�Ǹ��к�");
       cbmusic.addItem("���һ��");
       cbmusic.setVisible(true);   
       cbmusic.setSize(300,30);
       cbmusic.setBounds(230, 10, 250, 30);
       cbmusic.addItemListener(this);
       con.add(cbmusic);
       con.add(ok);
       ok.setBounds(490, 10, 70, 30);
       ok.addActionListener(this);       
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
       jp.setBounds(60, 50, 250, 70);
       jp.setVisible(false);
       con.add(jp);
       makephoto m=new makephoto();
       m.makebeijign(this, con, "src/image/����.jpg");       
       setLayout(null);
       setBounds(200,10,1000,800);
       setVisible(true);
      }
public void actionPerformed (ActionEvent e){ // ʵ�ּ���������
     if (e.getSource () == button_play) {
    	 
    	 if(b==false)
    	 {
    		 int n=JOptionPane.showConfirmDialog(null, "�Ƿ���ֹͣǰһ�׸�Ĳ���?", "��ʾ",JOptionPane.YES_NO_CANCEL_OPTION);
    				 if(n==JOptionPane.YES_OPTION)
    				 {
		    			 this.ac.stop(); 
		    			 b=true;
		    			 JOptionPane.showMessageDialog(null, "�����²���");
    				 }
    	 }
    	 else
    	 {

    	 this. ac= JApplet.newAudioClip(url);
    	 ac.play();
    	 b=false;
    	 }
     
     }else if (e.getSource () == button_loop) {

     this.ac.loop();// ѭ������
     }
     if (e.getSource ()== button_stop) {

     this.ac.stop();// ֹͣ����
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
			 File f = new File("C:\\Users\\Administrator\\Desktop\\java--QQ���˿ռ�\\QQ1\\src\\music\\"+this.mname+".wav"); //����������������ļ����ڵľ���¹��
			 this.label.setText("��������ɹ�!�����ť��ʼ����!");
			 this.url = f.toURL(); 			
			 }catch (MalformedURLException e1) { 
				 e1.printStackTrace(); 
			 } 
			 //url = getClass ().getResource(this.mname+".wav"); 
		 }
}
}
