using System.Globalization;

namespace ExeFixacaoLista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Salary { get; private set; }


        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salary = salario;
        }

        public void SalaryAdd(double porc)
        {
            Salary += Salary * porc / 100;
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + "R$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
