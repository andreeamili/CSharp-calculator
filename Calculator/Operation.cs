
namespace Calculator
{
    class Operation
    {
        protected Termn stringOfNumbers = new Termn(); 

        public virtual string PoloForm() { return ""; }

        public virtual decimal CalculFinal(string poloexp) { return 0; }
    }
}
