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
public chatServer () {    // ���ý���
    mainJframe=new JFrame ("����һһ��������") ;
    con=mainJframe.getContentPane () ;

    showArea=new JTextArea () ;//�����ı���
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
    mainJframe.setSize(500,400) ;
    mainJframe.setVisible (true) ;
    mainJframe.setDefaultCloseOperation (JFrame.EXIT_ON_CLOSE) ;
try{

    serverSocket=new ServerSocket (5500) ;// ���������׽���
    showArea.append("���ڵȴ��Ի�����\n") ;

    connectToclient=serverSocket.accept () ;// �����ͻ��˵�����
    inFromClient=new DataInputStream (connectToclient.getInputStream ()) ;
    outToclient=new DataOutputStream (connectToclient.getOutputStream() );
    thread=new Thread (this) ; // �����߳��ں�̨�����նԷ�����Ϣ
    thread.setPriority (Thread.MIN_PRIORITY) ;
    thread.start () ;
  }catch (IOException e) {
    showArea.append ("�Բ��𣬲��ܴ���������\n") ;
    msgText.setEditable (false) ;
    sentBtn.setEnabled(false) ;
  }
 }
public void actionPerformed (ActionEvent e) {// ��Ӧ��ť�¼���������Ϣ���Է�
    String s=msgText.getText () ;
    if (s.length()>0) {
try{
    outToclient.writeUTF(s) ;
    outToclient.flush() ;
    showArea.append ("��˵: "+msgText.getText () +"\n") ;
    msgText.setText (null) ;
  }
    catch (IOException el) {
         showArea.append ("�����Ϣ: ��"+msgText.getText () +"�� δ�ܷ��ͳ�ȥ\n" );
    }
   }
}
 
public void run() { // ���̸߳��𽫿ͻ�����������Ϣ��ʾ�ڶԻ�����
    try{
          while(true) {
                showArea.append ("�Է�˵: "+inFromClient.readUTF () +"\n") ;
                Thread.sleep(1000) ;
          }
    }catch (IOException el) {
    }catch (InterruptedException e){ }
}
public static void main(String[] args) {
	// TODO �Զ����ɵķ������
	new chatServer();
}

}
