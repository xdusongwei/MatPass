using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MatPassword
{
    class GridVM : DependencyObject
    {
        public Border Item
        {
            get { return (Border)GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Item.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemProperty =
            DependencyProperty.Register("Item", typeof(Border), typeof(GridVM), new PropertyMetadata(null));
        
        public Brush Back
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Background.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(GridVM), new PropertyMetadata(null));

        public System.Windows.Media.ImageSource Img
        {
            get { return (System.Windows.Media.ImageSource)GetValue(ImgProperty); }
            set { SetValue(ImgProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Img.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImgProperty =
            DependencyProperty.Register("Img", typeof(System.Windows.Media.ImageSource), typeof(GridVM), new PropertyMetadata(null));
    }
}
