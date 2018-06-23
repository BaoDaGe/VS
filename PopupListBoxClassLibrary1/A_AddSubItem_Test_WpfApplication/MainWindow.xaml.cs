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
using A_AddSubItem_WpfControlLibrary;
namespace A_AddSubItem_Test_WpfApplication
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //addSubItem1.AddSubItemText = "abc";
            addSubItem1.PersonSampleLeft.ImagePathA = @"\Resources\TouchButtonSelectedLeftA.jpg";
            addSubItem1.PersonSampleLeft.ImagePathB = @"\Resources\TouchButtonSelectedLeftB.jpg";
            addSubItem1.PersonSampleLeft.textblockstring = "Left";
            addSubItem1.PersonSampleRight.ImagePathA = @"\Resources\TouchButtonSelectedRightA.jpg";
            addSubItem1.PersonSampleRight.ImagePathB = @"\Resources\TouchButtonSelectedRightB.jpg";
            addSubItem1.PersonSampleRight.textblockstring = "Right";
            addSubItem1.ImageBrushPathUp.ImageBrushPath = @"\Resources\TouchButtonDisable.jpg";
            addSubItem1.AddSubItemText = "adddddds";
            addSubItem1.ImageBrushPathDown.ImageBrushPath = @"\Resources\TouchButtonDisable.jpg";
            addSubItem1.ImageBrushPathDown.ValueDown = "222555";
            this.addSubItem1.ButtonClick += new EventHandler(UserControl_ButtonClick);
        }
        protected void UserControl_ButtonClick(object sender, EventArgs e)
        {
            AddSubItem control = (AddSubItem)sender;
            MessageBox.Show(control.Name);
            MessageBox.Show(control.SelectedDirect);
            //RoutedEventArgs ee = (RoutedEventArgs)e;
            //(ee.OriginalSource as FrameworkElement).Name;
            //    TextBlock btn = sender as TextBlock;
            //string abc = btn.Text.ToString();
            //MessageBox.Show(btn.Text.ToString());

        }
    }
}
