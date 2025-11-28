using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TabControlExtSample1
{
	public  class ViewModel : NotificationObject
	{
		
		public ViewModel()
		{

		}

		public ImageSource DisplayedImage
		{
			
			get {				
				return new BitmapImage(new Uri("pack://application:,,,/TabControlExtSample1;component/star1.png"));
				}		
	
			
		}

	}
}
