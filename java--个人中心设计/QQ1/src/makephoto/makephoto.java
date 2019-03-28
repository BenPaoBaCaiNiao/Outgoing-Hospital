/**
 * 
 */
/**
 * @author Administrator
 *
 */
package makephoto;
import java.awt.*;

import javax.swing.*;
public class makephoto extends JFrame
{
	ImageIcon image;
	Image img;
	public void makephone(JLabel jl,String filename)
	{
		int width=50,height=50;
		this.image=new ImageIcon(filename);		
		img=image.getImage();
		img = img.getScaledInstance(width, height, Image.SCALE_DEFAULT);				
		image.setImage(img);		
		jl.setIcon(image);
	}
	public void makebeijign(JFrame jf,Container con,String filename)
	{
			image=new ImageIcon(filename);
			img=image.getImage();
			image.setImage(img);
			JLabel imgLabel = new JLabel(image);//将背景图放在标签里
			jf.getLayeredPane().add(imgLabel, new Integer(Integer.MIN_VALUE));//注意这里是关键，将背景标签添加到jfram的LayeredPane面板里
			imgLabel.setBounds(0,0,image.getIconWidth(), image.getIconHeight());//设置背景标签的位置
			((JPanel)con).setOpaque(false);		
			
	}

}

