using GerenciamentoProject.Data;
using GerenciamentoProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoProject.Repositorio
{
    public class DescontosRepositorio : IDescontosRepositorio
    {
        private readonly ApplicationDbContext _context;
        public DescontosRepositorio(ApplicationDbContext dbContext)
        {
            _context = dbContext;

        }
        public static double CalcDescontos(double HoraExtra,
            double Faltas,
            double SalarioBruto,
            double Atraso)
        {

            if (Atraso != null && Atraso > 0)
            {
                double descAtraso = (SalarioBruto / 200) * (int)Atraso;
                SalarioBruto -= descAtraso;
            }
            if (Faltas != null && Faltas > 0)
            {
                double descAtraso = (SalarioBruto / 30) * (int)Faltas;
                SalarioBruto -= descAtraso;
            }




            if (Faltas != null && HoraExtra > 0)
            {
                double descAtraso = (SalarioBruto / 200) * (int)Faltas;
                SalarioBruto -= descAtraso;

            }

            return SalarioBruto;
        }


        public static double CalculoFGTS(double SalarioBruto)
        {

            return SalarioBruto * 0.08;
        }


        public static int CalculoHrDia(int HorasporSemana)

        {
            return HorasporSemana * 5;
        }



        public static double CalculoINSS(double SalarioBruto)
        {
            double SalarioFinal = 0;

            if (SalarioBruto <= 1320)
            {
                SalarioFinal = SalarioBruto * (7.5 / 100);
            }
            else if (ValorEntre(1320.01, 2571, SalarioBruto))
            {
                SalarioFinal = 99;
                SalarioFinal = SalarioBruto * (9 / 100);
            }

            else if (ValorEntre(2571.1, 3856.94, SalarioBruto))
            {
                SalarioFinal = 99;
                SalarioFinal += 112.62;
                SalarioFinal = SalarioBruto * (12 / 100);
            }
            else if (ValorEntre(2571.1, 3856.94, SalarioBruto))
            {
                SalarioFinal = 99;
                SalarioFinal += 112.62;
                SalarioFinal += 154.28;
                SalarioFinal = SalarioBruto * (14 / 100);
            }

            else if (SalarioBruto >= 7507.49)
            {
                SalarioFinal = 99;
                SalarioFinal += 112.62;
                SalarioFinal += 154.28;
                SalarioFinal += 511.08;

            }
            else
            {
                throw new Exception("Valor Invalido");
            }
            return SalarioFinal;
        }


        public static bool ValorEntre(double valorMin, double valorMax, double valor)
        {
            if (valor > valorMin && valor < valorMax)
            {
                return true;
            }
            return false;

        }

        public List<DescontosModel> BuscarTodos()
        {
            return _context.Descontos.ToList();

        }
        public DescontosModel Adicionar(DescontosModel descontos)
        {
            _context.Descontos.Add(descontos);
            this._context.SaveChanges();
            return descontos;
        }
    }
}

