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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        Dictionary<int, string> months = new Dictionary<int, string>()
{
    { 1, "January"},
    { 2, "February"},
    { 3, "March"},
    { 4, "April"},
    { 5, "May"},
    { 6, "June"},
    { 7, "July"},
    { 8, "August"},
    { 9, "September"},
    { 10, "October"},
    { 11, "November"},
    { 12, "December"},

};
        public MainWindow()
        {
            InitializeComponent();

            DateTime currentDate = DateTime.Now;
            tbDate.Text = $"{currentDate.DayOfWeek}, {currentDate.Day} {months[currentDate.Month]}";
            for (int i = 1; i < 7; i++)
            {
                var pare = new Pare();
                pare.pareNumber.Text = i.ToString();
                pare.tbTeacher.Text = "Афанасьев Алексей Васильевич";
                pare.tbRoom.Text = "21";
                pare.tbLesson.Text = "МДК.01.01 РПМ";
                pare.tbMark.Text = "5";
                spTimeTable.Children.Add(pare);
            }
        }
    }
}
