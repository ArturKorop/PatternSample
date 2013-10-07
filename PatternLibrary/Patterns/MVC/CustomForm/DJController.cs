using System;
using System.Windows.Forms;
using PatternLibrary.Patterns.MVC.Interface;

namespace PatternLibrary.Patterns.MVC.CustomForm
{
    public partial class DJController : Form
    {
        private readonly IController _controller;

        public DJController(IController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.SetBPM(Int32.Parse(textBox1.Text));
        }
    }
}
