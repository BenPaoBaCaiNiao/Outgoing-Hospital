package makephoto;
import java.awt.Graphics;
import java.awt.Image;
import javax.swing.ImageIcon;
import javax.swing.JTextArea;
public class shuobj extends JTextArea
{
	Image img;
	public shuobj(String filename)
	{		
		ImageIcon imageIcon=new ImageIcon(filename);
		img=imageIcon.getImage();
		setOpaque(false);
	}
	public void paint(Graphics g)
	{
		g.drawImage(img,0,0,this);
		super.paint(g);
	}
}
