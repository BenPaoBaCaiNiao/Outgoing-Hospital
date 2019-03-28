package chatroom;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.net.*;

import javax.swing.*;

public class chatClient implements ActionListener,Runnable{
		 JTextArea showArea;
		   JTextField msgText;
		   JFrame mainJframe ;
		   JButton sentBtn;
		   JScrollPane JSPane;
		   JPanel pane;
		   Container con; 
		   Thread thread=null;
		   Socket connectToServer;
		   DataInputStream inFromServer;
		   DataOutputStream outToServer;
		public chatClient () {
		   mainJframe=new JFrame ("����һ�ͻ���") ;
		   con=mainJframe.getContentPane () ;
		   showArea=new JTextArea () ;
		   showArea.setEditable (false) ;
		   showArea.setLineWrap (true) ;
		   JSPane=new JScrollPane (showArea) ;// �����������
		    msgText=new JTextField () ;// �����ı���
		    msgText.setColumns (30) ;
		    msgText.addActionListener (this) ;
		    sentBtn=new JButton ("����") ;// �������Ͱ�ť
		    sentBtn.addActionListener(this) ;
		     pane=new JPanel () ;
		    pane.setLayout (new FlowLayout ()) ;// ����������ֹ���
		    pane.add (msgText) ;
		    pane.add (sentBtn) ;
		   con.add (JSPane,BorderLayout.CENTER) ;
		   con.add (pane,BorderLayout.SOUTH) ;
		   mainJframe.setSize (500,400) ;
		   mainJframe.setVisible (true) ;


		try{                                    // �����׽������ӵ�������
		   connectToServer=new Socket ("localhost",5500) ;
		   inFromServer=new DataInputStream (connectToServer.getInputStream() );
		   outToServer=new DataOutputStream (connectToServer.getOutputStream() );
		   showArea.append ("���ӳɹ�����˵��\n") ;
		   thread=new Thread (this) ;// �����߳��ں�̨����Է�����Ϣ
		   thread.setPriority (Thread.MIN_PRIORITY) ;
		   thread.start () ;
		   }catch (IOException e) {
		   showArea.append ("�Բ���û�����ӵ�������\n" );
		   msgText.setEditable (false) ;
		   sentBtn.setEnabled (false) ;
		   }
		}
		public void actionPerformed (ActionEvent e) { //��Ӧ��ť�¼���������Ϣ���Է�
		    String s=msgText.getText () ;
		    if (s.length()>0) {
		     try{
		    outToServer.writeUTF (s) ;
		    outToServer.flush () ;
		    showArea.append ("��˵: "+msgText.getText () +"\n") ;
		    msgText.setText (null) ;
		  }catch (IOException el) {
		       showArea.append ("�����Ϣ: ��"+msgText.getText () +"��δ�ܷ��ͳ�ȥ\n") ;
		  }
		    }
		}

		public void run () {             // ���̸߳��𽫷�������������Ϣ��ʾ�ڶԻ�����s
		   try{
		       while(true) {
		           showArea.append ("�Է�˵: "+inFromServer.readUTF() +"\n") ;
		           Thread.sleep (1000) ;
		       }
		       }catch (IOException el) {
		       }catch (InterruptedException e){ }
		}
		public static void main(String[] args) {
			// TODO �Զ����ɵķ������
			new chatClient();
		}

}
