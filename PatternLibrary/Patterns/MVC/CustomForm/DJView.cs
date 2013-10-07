using System;
using System.Globalization;
using System.Windows.Forms;
using PatternLibrary.Patterns.MVC.Interface;

namespace PatternLibrary.Patterns.MVC.CustomForm
{
    public partial class DJView : Form, IBeatObserver, IBPMObserver
    {
        public DJView()
        {
            InitializeComponent();
        }

        public void UpdateBPM(int bpm)
        {
            Invoke(new Action<int>(UpdateBPMIndicator), bpm);
        }

        public void UpdateTempo(int tempo)
        {
            Invoke(new Action<int>((i) =>
                {
                    progressBar1.Value = i;
                }), tempo);
        }

        private void UpdateBPMIndicator(int bpm)
        {
            lCurrentBPM.Text = bpm.ToString(CultureInfo.InvariantCulture);
        }
    }
}
