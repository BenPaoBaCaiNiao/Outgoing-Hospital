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
			JLabel imgLabel = new JLabel(image);//������ͼ���ڱ�ǩ��
			jf.getLayeredPane().add(imgLabel, new Integer(Integer.MIN_VALUE));//ע�������ǹؼ�����������ǩ��ӵ�jfram��LayeredPane�����
			imgLabel.setBounds(0,0,image.getIconWidth(), image.getIconHeight());//���ñ�����ǩ��λ��
			((JPanel)con).setOpaque(false);		
			
	}

}

