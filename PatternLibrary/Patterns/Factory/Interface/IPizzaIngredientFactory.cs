using PatternLibrary.Patterns.Factory.Interface.Ingredients;

namespace PatternLibrary.Patterns.Factory.Interface
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggie[] CreateVeggies();
        IClam CreateClam();
        IPepperoni CreatePepperoni();
    }
}