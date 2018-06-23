using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.ComponentModel;
using PopupListBoxClassLibrary1;
namespace WpfControlLibrary_ItemsList
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class ItemsList: UserControl
    {

        public int Index = -1;

        public ModeDetail ModeDetailVar = new ModeDetail();
        public ItemsList()
        {
            InitializeComponent();
            Button1.DataContext = ModeDetailVar;

        }
        public class ModeDetail : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            private string pixellength;
            public string PixelLength
            {
                get { return pixellength; }
                set
                {
                    pixellength = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("PixelLength"));
                }
            }
            private string smodedetail;
            public string SModeDetail
            {
                get { return smodedetail; }
                set
                {
                    smodedetail = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("SModeDetail"));
                }
            }
            private string imagedefaultimagepath;
            public string ImageDefaultImagePath
            {
                get { return imagedefaultimagepath; }
                set
                {
                    imagedefaultimagepath = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ImageDefaultImagePath"));
                }
            }
            private string imageselectedimagepath;
            public string ImageSelectedImagePath
            {
                get { return imageselectedimagepath; }
                set
                {
                    imageselectedimagepath = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ImageSelectedImagePath"));
                }
            }
        }
        public List<PopupListBox> ItemsSourceList
        {
            get { return (List<PopupListBox>)GetValue(ItemsSourceListProperty); }
            set { SetValue(ItemsSourceListProperty, value); }
        }
        public static readonly DependencyProperty ItemsSourceListProperty =
            DependencyProperty.Register("ItemsSourceList", typeof(List<PopupListBox>), typeof(ItemsList), new UIPropertyMetadata(new List<PopupListBox>()));
        public string SmodeTitle
        {
            get { return (string)GetValue(SmodeTitleProperty); }
            set { SetValue(SmodeTitleProperty, value); }
        }
        public static readonly DependencyProperty SmodeTitleProperty =
            DependencyProperty.Register("SmodeTitle", typeof(string), typeof(ItemsList), new UIPropertyMetadata());
        public event MouseButtonEventHandler MouseButtonChanged;
        private void TemplateClick(object sender, RoutedEventArgs e)
        {
            if (this.Popup1.IsOpen == true)
                this.Popup1.IsOpen = false;
            else if (this.Popup1.IsOpen == false)
                this.Popup1.IsOpen = true;
        }
        private void PopupListBoxXaml_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Index = PopupListBoxXaml.SelectedIndex;
            this.Popup1.IsOpen = false;
            ModeDetailVar.SModeDetail = ItemsSourceList.ElementAt(Index).SModeText;
            if (this.MouseButtonChanged != null)
                this.MouseButtonChanged(this, e);
        }
    }
}
