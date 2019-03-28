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
		    // 显示输人和结果的文本域
		    Button pointButton,equalButton,plusButton;
		  Button minusButton,clearButton,multiButton,divisionButton;
		   //运算符按钮
		Button[] b=new Button[10] ;//数字按钮

		String currentOp,preOp;//当前操作和上一步操作

		String foreText,backText;//当前输人和上一次输人

		boolean isFloat= false;//运算类型标志
		public jisuanqi ()
		{           //实例化面板

		Panel panel1=new Panel () ;//实例化面板
		Panel panel2=new Panel () ;
		Panel panel3=new Panel () ;
		currentOp= new String("") ;//实例化各组件
		preOp = new String("");
		foreText = new String ("") ;
		backText= new String("") ;
		answerText = new TextField(20) ;
		this.setBackground (Color.lightGray) ; //设置Applet 背景色
		this.setForeground (Color.blue) ; //设置Applet 前景色
		for(int i=9;i>=0;i--)
		{
			b[i]=new Button(Integer.toString(i) );		
					//实例化数字按钮
					
					panel2.add(b[i]) ;//增加按钮到面板
		}
			
					pointButton = new Button(".") ;//实例化按钮
					equalButton= new Button ("=") ;				
					equalButton.setForeground (Color.red) ;//设置按钮前景色
					clearButton = new Button("清除") ;
					clearButton.setForeground(Color.red) ;
					divisionButton= new Button ("/") ;
					divisionButton.setForeground(Color.red) ;
					multiButton = new Button("*") ;
					multiButton.setForeground(Color.red) ;
					minusButton = new Button ("-") ;
					minusButton.setForeground (Color.red) ;
					plusButton= new Button("+") ;
					plusButton.setForeground(Color.red) ;
					
					setLayout (new FlowLayout () );  //设置布局管理器
					panel1.setLayout (new FlowLayout () );
					panel2.setLayout (new GridLayout (4,3) );
					panel3.setLayout (new GridLayout (4,1) );
				
					panel1.add (answerText) ;
					//增加组件到面板
					panel1.add (clearButton) ;
					panel2.add (pointButton) ;
				    panel2.add (equalButton) ;
					panel3.add (plusButton) ;
					panel3.add (minusButton) ;
					panel3.add (multiButton) ;
					panel3.add (divisionButton) ;
					
					add (panel1) ;//增加组件到Applet
					add (panel2);
					add(panel3) ;
					this.add(panel1);
					this.add(panel2);
					this.add(panel3);
					this.setVisible(true);
					this.setBounds(400,250,300,300);
		}
		public boolean action (Event e,Object o) {
					
					//事件处理
			     String s=new String("") ;
					
					for (int i=0;i<10;i++) {
					  if (e.target==b[i]||e.target==pointButton)
					  {    // 按钮事件来自于数字按钮和点按钮
					     if (e.target != pointButton)
					     {
						  s= (String)o;
						  doForeText(s);//处理输入;
					     }
					
				
					if((e.target==pointButton)&&(!isFloat))
					{   //浮点数输人

						isFloat= true;//设置运算标志
					
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
		    {//处理运算
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
		    { //等于按钮事件处理
		    	doOperator();//处理运算
		    	
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
		       answerText.setText (backText) ;//显示文本
		    }
		    else
		    {
		        dFore = (new Double (foreText)).doubleValue () ;//得到第一输入
		        dBack = (new Double (backText) ).doubleValue () ;//得到第二输入
		        foreText = "";
		        backText = answerText.getText () ;
		        
		        if (preOp.equals ("+") )
		        {  //加运算处理
		             d= new Double ((dBack + dFore) );//得到显示结果
		             answerText.setText (d.toString () );//显示运算结果
		             backText = d.toString () ;
		        }
		        if(preOp.equals ("-") )
		        {
		        d = new Double ((dBack - dFore) );  //得到显示结果
		        answerText.setText (d.toString () );  //显示运算结果
		        backText = d.toString () ;
		        }
		       if(preOp.equals ("*") )
		       {
		    	   d= new Double ((dBack * dFore) );//得到显示结果
		           answerText.setText (d.toString () );//显示运算结果
		           backText = d.toString () ;
		       }
		       if(preOp.equals("/"))
		       {
		    	   if (dFore==0)
		    	   {  
		    		   answerText.setText("除数不能为0");//显示出错信息
		    		   return;
		    	   }
		    	   d= new Double ((dBack / dFore) );//得到显示结果
		           answerText.setText (d.toString () );//显示运算结果
		           backText = d.toString () ;
		       }
		    }
		   preOp=currentOp;
		}
		public void doForeText(String s)
		{    
			foreText += s;
			answerText.setText (foreText) ;//显示输 人
		}
			public void doBackText (String s)
			{
			   backText= foreText;
			    foreText = "" ;
			
			    answerText.setText (foreText) ;//显示输入
			}
			
			public void doClear () {//清除输入
			
			currentOp= "";
			preOp="";
			foreText="";
			backText= "";
			isFloat= false;
			answerText.setText ("") ;
			}
	}

