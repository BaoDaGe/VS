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
using PopupListBoxClassLibrary1;
using WpfControlLibrary_ItemsList;
namespace WpfApplication_ItemsList_Text
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        static int selectindex = -1;
        List<PopupListBox> View = new List<PopupListBox>()
            {
               new PopupListBox(){ PixelLength="30", SModeText="ViewDir1", ImageDefaultImagePath=@"\Resources\TouchButtonDisable.jpg", ImageSelectedImagePath=@"\Resources\TouchButtonSelected.jpg" },
               new PopupListBox(){PixelLength="30", SModeText = "ViewDir12", ImageDefaultImagePath=@"\Resources\TouchButtonDisable.jpg", ImageSelectedImagePath=@"\Resources\TouchButtonSelected.jpg" },
               new PopupListBox(){ PixelLength="50",SModeText="ViewDir13", ImageDefaultImagePath=@"\Resources\TouchButtonDisable.jpg", ImageSelectedImagePath=@"\Resources\TouchButtonSelected.jpg" },
              new PopupListBox(){PixelLength="50", SModeText="ViewDir14", ImageDefaultImagePath=@"\Resources\TouchButtonDisable.jpg", ImageSelectedImagePath=@"\Resources\TouchButtonSelected.jpg" },
              new PopupListBox(){PixelLength="50",SModeText="ViewDir15", ImageDefaultImagePath=@"\Resources\TouchButtonDisable.jpg", ImageSelectedImagePath=@"\Resources\TouchButtonSelected.jpg" },
              new PopupListBox(){PixelLength="50",SModeText="ViewDir16", ImageDefaultImagePath=@"\Resources\TouchButtonDisable.jpg", ImageSelectedImagePath=@"\Resources\TouchButtonSelected.jpg" },
            };
        public MainWindow()
        {
            InitializeComponent();
            this.itemsList1.Index = 0;
            this.itemsList1.SmodeTitle = "ViewDir";
            this.itemsList1.ItemsSourceList = View;
            this.itemsList1.ModeDetailVar.ImageDefaultImagePath = @"\Resources\TouchButtonSelected.jpg";
            this.itemsList1.ModeDetailVar.ImageSelectedImagePath = @"\Resources\TouchButtonSelected.jpg";
            this.itemsList1.ModeDetailVar.SModeDetail = this.itemsList1.ItemsSourceList.ElementAt(this.itemsList1.Index).SModeText;
            // this.itemsList1.AddHandler(ItemsList.MouseLeftButtonUpEvent, new MouseButtonEventHandler(this.UserControl_ButtonClick), true);

            this.itemsList1.MouseButtonChanged += new MouseButtonEventHandler(UserControl_ButtonClick);


            //   btnTop.AddHandler(Button.MouseLeftButtonUpEvent, new RoutedEventHandler(btnTop_MouseLeftButtonDown), true);
        }
        private void UserControl_ButtonClick(object sender, MouseButtonEventArgs e)
        {

            ItemsList control = (ItemsList)sender;
            //if (selectindex == control.Index)
            //{
            //}
            //else
            {
                selectindex = control.Index;
                System.Diagnostics.Debug.WriteLine(control.Index.ToString());
                //   MessageBox.Show(control.Index.ToString());
            }

        }
      
    }
}
