package chatroom;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.net.*;

import javax.swing.*;
public class chatServer implements ActionListener,Runnable {
	JTextArea showArea;
    JTextField msgText;
    JFrame mainJframe ;
    JButton sentBtn; 
    Container con;
    JScrollPane  JSPane;
    JPanel pane;
    ServerSocket serverSocket;
	Socket connectToclient;
	DataInputStream inFromClient;
	DataOutputStream outToclient;
	Thread thread;
public chatServer () {    // 设置界面
    mainJframe=new JFrame ("聊天一一服务器端") ;
    con=mainJframe.getContentPane () ;

    showArea=new JTextArea () ;//创建文本域
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
    mainJframe.setSize(500,400) ;
    mainJframe.setVisible (true) ;
    mainJframe.setDefaultCloseOperation (JFrame.EXIT_ON_CLOSE) ;
try{

    serverSocket=new ServerSocket (5500) ;// 创建服务套接字
    showArea.append("正在等待对话请求\n") ;

    connectToclient=serverSocket.accept () ;// 侦听客户端的连接
    inFromClient=new DataInputStream (connectToclient.getInputStream ()) ;
    outToclient=new DataOutputStream (connectToclient.getOutputStream() );
    thread=new Thread (this) ; // 启动线程在后台来接收对方的消息
    thread.setPriority (Thread.MIN_PRIORITY) ;
    thread.start () ;
  }catch (IOException e) {
    showArea.append ("对不起，不能创建服务器\n") ;
    msgText.setEditable (false) ;
    sentBtn.setEnabled(false) ;
  }
 }
public void actionPerformed (ActionEvent e) {// 响应按钮事件，发送消息给对方
    String s=msgText.getText () ;
    if (s.length()>0) {
try{
    outToclient.writeUTF(s) ;
    outToclient.flush() ;
    showArea.append ("我说: "+msgText.getText () +"\n") ;
    msgText.setText (null) ;
  }
    catch (IOException el) {
         showArea.append ("你的消息: “"+msgText.getText () +"” 未能发送出去\n" );
    }
   }
}
 
public void run() { // 本线程负责将客户机传来的信息显示在对话区域
    try{
          while(true) {
                showArea.append ("对方说: "+inFromClient.readUTF () +"\n") ;
                Thread.sleep(1000) ;
          }
    }catch (IOException el) {
    }catch (InterruptedException e){ }
}
public static void main(String[] args) {
	// TODO 自动生成的方法存根
	new chatServer();
}

}
