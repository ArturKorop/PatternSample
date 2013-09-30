using Common.Code;
using PatternLibrary.Patterns.Facade.Code.Facade;
using PatternLibrary.Patterns.Facade.Code.Objects;

namespace PatternLibrary.Patterns.Facade
{
    [Runnable]
    public class FacadeStarter
    {
         public static void Start()
         {
             var homeTheater = new HomeTheaterFacade(new Amp(), new Popper(), new Screen());
             homeTheater.On("Enemy within");
             homeTheater.Off();
         }
    }
}