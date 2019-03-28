import java.awt.Button;
import java.awt.Color;
import java.awt.Event;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.Panel;
import java.awt.TextField;

import javax.swing.JFrame;


public 	class jisuanqi extends JFrame{
		 TextField answerText;
		    // ��ʾ���˺ͽ�����ı���
		    Button pointButton,equalButton,plusButton;
		  Button minusButton,clearButton,multiButton,divisionButton;
		   //�������ť
		Button[] b=new Button[10] ;//���ְ�ť

		String currentOp,preOp;//��ǰ��������һ������

		String foreText,backText;//��ǰ���˺���һ������

		boolean isFloat= false;//�������ͱ�־
		public jisuanqi ()
		{           //ʵ�������

		Panel panel1=new Panel () ;//ʵ�������
		Panel panel2=new Panel () ;
		Panel panel3=new Panel () ;
		currentOp= new String("") ;//ʵ���������
		preOp = new String("");
		foreText = new String ("") ;
		backText= new String("") ;
		answerText = new TextField(20) ;
		this.setBackground (Color.lightGray) ; //����Applet ����ɫ
		this.setForeground (Color.blue) ; //����Applet ǰ��ɫ
		for(int i=9;i>=0;i--)
		{
			b[i]=new Button(Integer.toString(i) );		
					//ʵ�������ְ�ť
					
					panel2.add(b[i]) ;//���Ӱ�ť�����
		}
			
					pointButton = new Button(".") ;//ʵ������ť
					equalButton= new Button ("=") ;				
					equalButton.setForeground (Color.red) ;//���ð�ťǰ��ɫ
					clearButton = new Button("���") ;
					clearButton.setForeground(Color.red) ;
					divisionButton= new Button ("/") ;
					divisionButton.setForeground(Color.red) ;
					multiButton = new Button("*") ;
					multiButton.setForeground(Color.red) ;
					minusButton = new Button ("-") ;
					minusButton.setForeground (Color.red) ;
					plusButton= new Button("+") ;
					plusButton.setForeground(Color.red) ;
					
					setLayout (new FlowLayout () );  //���ò��ֹ�����
					panel1.setLayout (new FlowLayout () );
					panel2.setLayout (new GridLayout (4,3) );
					panel3.setLayout (new GridLayout (4,1) );
				
					panel1.add (answerText) ;
					//������������
					panel1.add (clearButton) ;
					panel2.add (pointButton) ;
				    panel2.add (equalButton) ;
					panel3.add (plusButton) ;
					panel3.add (minusButton) ;
					panel3.add (multiButton) ;
					panel3.add (divisionButton) ;
					
					add (panel1) ;//���������Applet
					add (panel2);
					add(panel3) ;
					this.add(panel1);
					this.add(panel2);
					this.add(panel3);
					this.setVisible(true);
					this.setBounds(400,250,300,300);
		}
		public boolean action (Event e,Object o) {
					
					//�¼�����
			     String s=new String("") ;
					
					for (int i=0;i<10;i++) {
					  if (e.target==b[i]||e.target==pointButton)
					  {    // ��ť�¼����������ְ�ť�͵㰴ť
					     if (e.target != pointButton)
					     {
						  s= (String)o;
						  doForeText(s);//��������;
					     }
					
				
					if((e.target==pointButton)&&(!isFloat))
					{   //����������

						isFloat= true;//���������־
					
					s = (String) o;
					if (foreText.equals (""))
					{
					  foreText  += "0.";
					}
					else
					{
						doForeText(s);
					}
				 }
					
			   }	
		    }		
			if ((e.target==multiButton)||(e.target==divisionButton)
			||(e.target==plusButton)||(e.target==minusButton))
		    {//��������
			     if	(foreText !="")
			     {
			    	 currentOp=((String)o);
			    	 doOperator();
			     }
			     else
			     {
			    	 preOp=((String)o);
			     }
			  }
		    if (e.target==equalButton)
		    { //���ڰ�ť�¼�����
		    	doOperator();//��������
		    	
		    }
		    if(e.target==clearButton)
		    	doClear();
		    
		    return true;
		}
		public void doOperator () 
		{
		    double dFore,dBack;
		    Double d;
		    if(preOp.equals(""))
		    {
		       backText = foreText;
		       foreText = "";
		       answerText.setText (backText) ;//��ʾ�ı�
		    }
		    else
		    {
		        dFore = (new Double (foreText)).doubleValue () ;//�õ���һ����
		        dBack = (new Double (backText) ).doubleValue () ;//�õ��ڶ�����
		        foreText = "";
		        backText = answerText.getText () ;
		        
		        if (preOp.equals ("+") )
		        {  //�����㴦��
		             d= new Double ((dBack + dFore) );//�õ���ʾ���
		             answerText.setText (d.toString () );//��ʾ������
		             backText = d.toString () ;
		        }
		        if(preOp.equals ("-") )
		        {
		        d = new Double ((dBack - dFore) );  //�õ���ʾ���
		        answerText.setText (d.toString () );  //��ʾ������
		        backText = d.toString () ;
		        }
		       if(preOp.equals ("*") )
		       {
		    	   d= new Double ((dBack * dFore) );//�õ���ʾ���
		           answerText.setText (d.toString () );//��ʾ������
		           backText = d.toString () ;
		       }
		       if(preOp.equals("/"))
		       {
		    	   if (dFore==0)
		    	   {  
		    		   answerText.setText("��������Ϊ0");//��ʾ������Ϣ
		    		   return;
		    	   }
		    	   d= new Double ((dBack / dFore) );//�õ���ʾ���
		           answerText.setText (d.toString () );//��ʾ������
		           backText = d.toString () ;
		       }
		    }
		   preOp=currentOp;
		}
		public void doForeText(String s)
		{    
			foreText += s;
			answerText.setText (foreText) ;//��ʾ�� ��
		}
			public void doBackText (String s)
			{
			   backText= foreText;
			    foreText = "" ;
			
			    answerText.setText (foreText) ;//��ʾ����
			}
			
			public void doClear () {//�������
			
			currentOp= "";
			preOp="";
			foreText="";
			backText= "";
			isFloat= false;
			answerText.setText ("") ;
			}
	}

