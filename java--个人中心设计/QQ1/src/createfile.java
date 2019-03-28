import java.io.File;
import java.io.IOException;

import javax.swing.JOptionPane;


public class createfile {
		public createfile()
		{		
		File file=null;
		String name=JOptionPane.showInputDialog("请输入文件名");
		if(name!=null)
		{
		try{
		file=new File(name+".txt");
		file.createNewFile();
		JOptionPane.showMessageDialog(null, "文件创建成功");
		}
		catch(IOException e){}
		}
		else System.out.println("创建新文件失败");
		}
}
