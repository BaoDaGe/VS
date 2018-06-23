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
using System.ComponentModel;
namespace A_AddSubItem_WpfControlLibrary
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class AddSubItem : UserControl
    {
        public Person PersonSampleLeft = new Person();
        public Person PersonSampleRight = new Person();
        public string SelectedDirect;
        public TextBoxUpClass ImageBrushPathUp = new TextBoxUpClass();
        public TextBoxDownClass ImageBrushPathDown = new TextBoxDownClass();
        public AddSubItem()
        {
            InitializeComponent();
            this.PersonSampleLeft.ImagePathA = @"\Resources\TouchButtonSelectedLeftA.bmp";
            this.PersonSampleLeft.ImagePathB = @"\Resources\TouchButtonSelectedLeftB.bmp";
            this.PersonSampleLeft.textblockstring = "Left";
            this.PersonSampleRight.ImagePathA = @"\Resources\TouchButtonSelectedRightA.bmp";
            this.PersonSampleRight.ImagePathB = @"\Resources\TouchButtonSelectedRightB.bmp";
            this.PersonSampleRight.textblockstring = "Right";
            this.ImageBrushPathUp.ImageBrushPath = @"\Resources\TouchButtonDisable.bmp";
            this.ImageBrushPathUp.NameUp = "text";
            this.ImageBrushPathDown.ImageBrushPath = @"\Resources\TouchButtonDisable.bmp";
            this.ImageBrushPathDown.ValueDown = "0";
            this.imgleft.Content = PersonSampleLeft;
            this.imgright.Content = PersonSampleRight;
            this.TextBoxNameDown.DataContext = ImageBrushPathDown;
            this.TextBoxNameUp.DataContext = ImageBrushPathUp;
            //BindingOperations.SetBinding(this.TextBoxNameUp, TextBox.TextProperty, new Binding() { Path = new PropertyPath("NameUp"), Source = this.ImageBrushPathUp });
            BindingOperations.SetBinding(this.TextBoxNameDown, TextBox.TextProperty, new Binding() { Path = new PropertyPath("ValueDown"), Source = this.ImageBrushPathDown });


        }
        public class TextBoxUpClass : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            public string imagebrushpath;
            private string nameup;
            public string ImageBrushPath
            {
                get { return imagebrushpath; }
                set
                {
                    imagebrushpath = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ImageBrushPath"));
                }
            }
            public string NameUp
            {
                get { return nameup; }
                set
                {
                    nameup = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("NameUp"));
                }
            }
        }
        public class TextBoxDownClass : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            public string imagebrushpath;
            private string valuedown;
            public string ImageBrushPath
            {
                get { return imagebrushpath; }
                set
                {
                    imagebrushpath = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ImageBrushPath"));
                }
            }
            public string ValueDown
            {
                get { return valuedown; }
                set
                {
                    valuedown = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ValueDown"));
                }
            }
        }
        public class Person : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            public string imagepatha;
            public string imagepathb;
            public string textblockstring;
            public string ImagePathA
            {
                get { return imagepatha; }
                set
                {
                    imagepatha = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ImagePathA"));
                }
            }
            public string ImagePathB
            {
                get { return imagepathb; }
                set
                {
                    imagepathb = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ImagePathB"));
                }
            }

            public string TextBlockString
            {
                get { return textblockstring; }
                set
                {
                    textblockstring = value;
                    if (this.PropertyChanged != null)
                        this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("TextBlockString"));
                }
            }
        }
        public event EventHandler ButtonClick;
        private void TemplateClick(object sender, RoutedEventArgs e)
        {
            //   MessageBox.Show((e.OriginalSource as FrameworkElement).Name);
            TextBlock btn = sender as TextBlock;
            string abc = btn.Text.ToString();
            //   MessageBox.Show(btn.Text.ToString());
            SelectedDirect = abc;
            if (btn.Text.ToString().Equals("Left"))
            {
                //   ImageBrushPathDown.ValueDown-=1;
            }
            if (btn.Text.ToString().Equals("Right"))
            {
                //   ImageBrushPathDown.ValueDown+=1;
            }
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
        public string AddSubItemText
        {
            get { return (string)GetValue(AddSubItemTextProperty); }
            set { SetValue(AddSubItemTextProperty, value); }
        }
        public static readonly DependencyProperty AddSubItemTextProperty =
            DependencyProperty.Register("AddSubItemText", typeof(string), typeof(AddSubItem), new UIPropertyMetadata(""));
    }
}
