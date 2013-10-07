using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Code;
using Common.Code.Configuration;
using Microsoft.Practices.Unity;
using PatternLibrary.Patterns.MVC.Code.BPMObservers;
using PatternLibrary.Patterns.MVC.Code.Common;
using PatternLibrary.Patterns.MVC.CustomForm;
using PatternLibrary.Patterns.MVC.Interface;

namespace PatternLibrary.Patterns.MVC
{
    [Runnable(true)]
    public class MVCStarter
    {
        public static void Start()
        {
            DIServiceLocator.Current.RegisterType<ISequencer, FakeSequencer>();
            var beatModel = new BeatModel();
            var controller = new BeatController(beatModel);
            IBPMObserver consoleBPMObserver = new ConsoleBPMObserver();

            var formBPMObserver = new DJView();
            formBPMObserver.Closing += delegate { beatModel.RemoveObserver((IBPMObserver)formBPMObserver); };
            var temp = formBPMObserver;
            Task.Factory.StartNew(() => Application.Run(temp));

            var formController = new DJController(controller);
            Task.Factory.StartNew(() => Application.Run(formController));

            beatModel.RegisterObserver(consoleBPMObserver);
            beatModel.RegisterObserver((IBPMObserver)formBPMObserver);
            controller.Start();
        }

    }
}