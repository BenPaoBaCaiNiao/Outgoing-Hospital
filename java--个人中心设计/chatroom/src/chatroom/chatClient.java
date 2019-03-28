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
		   mainJframe=new JFrame ("聊天一客户端") ;
		   con=mainJframe.getContentPane () ;
		   showArea=new JTextArea () ;
		   showArea.setEditable (false) ;
		   showArea.setLineWrap (true) ;
		   JSPane=new JScrollPane (showArea) ;// 创建滚动面板
		    msgText=new JTextField () ;// 创建文本框
		    msgText.setColumns (30) ;
		    msgText.addActionListener (this) ;
		    sentBtn=new JButton ("发送") ;// 创建发送按钮
		    sentBtn.addActionListener(this) ;
		     pane=new JPanel () ;
		    pane.setLayout (new FlowLayout ()) ;// 进行组件布局管理
		    pane.add (msgText) ;
		    pane.add (sentBtn) ;
		   con.add (JSPane,BorderLayout.CENTER) ;
		   con.add (pane,BorderLayout.SOUTH) ;
		   mainJframe.setSize (500,400) ;
		   mainJframe.setVisible (true) ;


		try{                                    // 创建套接字连接到服务器
		   connectToServer=new Socket ("localhost",5500) ;
		   inFromServer=new DataInputStream (connectToServer.getInputStream() );
		   outToServer=new DataOutputStream (connectToServer.getOutputStream() );
		   showArea.append ("连接成功，请说话\n") ;
		   thread=new Thread (this) ;// 创建线程在后台处理对方的消息
		   thread.setPriority (Thread.MIN_PRIORITY) ;
		   thread.start () ;
		   }catch (IOException e) {
		   showArea.append ("对不起，没能连接到服务器\n" );
		   msgText.setEditable (false) ;
		   sentBtn.setEnabled (false) ;
		   }
		}
		public void actionPerformed (ActionEvent e) { //响应按钮事件，发送消息给对方
		    String s=msgText.getText () ;
		    if (s.length()>0) {
		     try{
		    outToServer.writeUTF (s) ;
		    outToServer.flush () ;
		    showArea.append ("我说: "+msgText.getText () +"\n") ;
		    msgText.setText (null) ;
		  }catch (IOException el) {
		       showArea.append ("你的消息: “"+msgText.getText () +"”未能发送出去\n") ;
		  }
		    }
		}

		public void run () {             // 本线程负责将服务器传来的信息显示在对话区域s
		   try{
		       while(true) {
		           showArea.append ("对方说: "+inFromServer.readUTF() +"\n") ;
		           Thread.sleep (1000) ;
		       }
		       }catch (IOException el) {
		       }catch (InterruptedException e){ }
		}
		public static void main(String[] args) {
			// TODO 自动生成的方法存根
			new chatClient();
		}

}
