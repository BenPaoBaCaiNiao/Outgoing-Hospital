import java.io.File;
import java.io.IOException;

import javax.swing.JOptionPane;


public class createfile {
		public createfile()
		{		
		File file=null;
		String name=JOptionPane.showInputDialog("�������ļ���");
		if(name!=null)
		{
		try{
		file=new File(name+".txt");
		file.createNewFile();
		JOptionPane.showMessageDialog(null, "�ļ������ɹ�");
		}
		catch(IOException e){}
		}
		else System.out.println("�������ļ�ʧ��");
		}
}
