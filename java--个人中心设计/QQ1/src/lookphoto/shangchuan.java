/**
 * 
 */
/**
 * @author Administrator
 *
 */
package lookphoto;
import java.awt.BorderLayout;
import java.awt.Container;
import java.awt.Frame;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

public class shangchuan extends JFrame implements ActionListener
{
	static String  fileName;
	JFrame jf=new JFrame("Í¼Æ¬Ô¤ÀÀ");
	JButton buttonFile=new JButton("Ô¤ÀÀ");
	ImagePanel imagePane=new ImagePanel();
	JButton buttonok=new JButton("È·¶¨");
	JLabel jl=new JLabel();
	public shangchuan()
	{			
		buttonok.addActionListener(this);
		buttonFile.addActionListener(this);
		JPanel jpanel=new JPanel();
		jpanel.add(buttonok);
		Container content=jf.getContentPane();
		content.add(buttonFile,BorderLayout.NORTH);
		content.add(buttonok,BorderLayout.SOUTH);
		content.add(imagePane,BorderLayout.CENTER);
		jf.setBounds(150, 150, 800, 700);
		jf.setVisible(true);		
	}
	public shangchuan(int i)
	{
		
	}
	public void actionPerformed(ActionEvent e)
	{
		String filename=null;
		if(e.getSource()==buttonFile)
		{
			JFileChooser choose=new JFileChooser();
			choose.setFileSelectionMode(JFileChooser.FILES_ONLY);
			choose.setCurrentDirectory(new File("."));
			choose.setFileFilter(new javax.swing.filechooser.FileFilter()
			{
				public boolean accept(File file){
					String name=file.getName().toLowerCase();
					return name.endsWith(".gif") || name.endsWith(".jpg") || name.endsWith(".jpeg") || file.isDirectory();
				}
				public String getDescription()
				{
					return "Í¼ÏñÎÄ¼þ";
				}
			});
			
			int result =choose.showOpenDialog(this);
			if(result==JFileChooser.APPROVE_OPTION)
			{
				 fileName=choose.getSelectedFile().getAbsolutePath();
				imagePane.loadImage(fileName);
			}
		}
		if(e.getSource()==buttonok)
		{
			if(fileName!="")
			{		
				this.fileName=filename;
				this.setVisible(false);
			}
		}

	}
	public String  getfilename()
	{
		return this.fileName;
	}

}
		
	
class ImagePanel extends JPanel
{
	JLabel jl=new JLabel();
	ImageIcon image;
	Image img;
	int width;
	int height;

	public void loadImage(String filename)	
	{		
		width=600;
		height=600;
		jl.setSize(width,height);
		this.image=new ImageIcon(filename);
		img=image.getImage();
		img = img.getScaledInstance(width, height, Image.SCALE_DEFAULT);
		image.setImage(img);
		this.jl.setIcon(image);
		this.add(jl);
		this.setVisible(true);
	}	

		
}

	//Image image;
	//BufferedImage bufImage;
	//BufferedImage originalBufImage;
	//Graphics2D G2D;
	//public void loadImage(String fileName)
	//{		
		//image=this.getToolkit().getImage(fileName);
		//MediaTracker mt=new MediaTracker(this);
		//mt.addImage(image, 0);
		//try
		//{
			//mt.waitForAll();
		//}
		//catch(Exception ex)
		//{
			//ex.printStackTrace();
		//}
		//originalBufImage=new BufferedImage(image.getWidth(this),image.getHeight(this),BufferedImage.TYPE_INT_ARGB);
		//G2D=originalBufImage.createGraphics();
		//G2D.drawImage(image,0,0,this);
		//bufImage=originalBufImage;
		//repaint();		
	//}
	//public void paint(Graphics g)
	//{
		//super.paintComponent(g);
		//if(bufImage!=null)			
		//{
			//Graphics2D G2=(Graphics2D) g;
			//G2.drawImage(bufImage, (this.getWidth()-bufImage.getWidth())/2, (this.getHeight()-bufImage.getHeight())/2,this);
		//}
	//}
