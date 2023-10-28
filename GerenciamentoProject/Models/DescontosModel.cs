using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoProject.Models
{
    public class DescontosModel 
    {
        [Key]
        [DisplayName("Digite o Id que a folha vai ser atribuido")]
        public int Id_Usuario{  get; set; }
        [DisplayName("Digite quantas horas extras o funcionario fez")]
        public double HoraExtra { get; set; }
        [DisplayName("Digite se o funcionario faltou algum dia")]
        public double Faltas { get; set; }
        [DisplayName("Digite o Salario Bruto para gerar o calculo ")]
        public double? SalarioBruto { get; set; }
        [DisplayName("Digite se o funcionario atrasou algum dia (Digite o valor em horas atrasadas ex:1hora=1)")]
        public double? Atraso {  get; set; }
        public double? SalarioFinal;
        [DisplayName("Digite o nome do funcionario que vai receber a folha")]
        public String? NomeFuncionario { get; set; }
        [DisplayName("Digite o Cargo do funcionario que vai receber a folha")]
        public String? Cargo {  get; set; }


        public static double CalcDescontos ( double HoraExtra,
            double Faltas,
            double SalarioBruto,
            double Atraso)
        {
            
            if (Atraso != null && Atraso > 0)
            {
                double descAtraso = (SalarioBruto/200) *(int) Atraso;
                SalarioBruto -= descAtraso;
            }
            if (Faltas!= null && Faltas > 0)
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
       
        
        public static int CalculoHrDia (int HorasporSemana)

        {
            return HorasporSemana * 5;
        }
       


        public static double CalculoINSS(double SalarioBruto) 
        {
            double SalarioFinal = 0;

            if (SalarioBruto <=1320 )
            {
                SalarioFinal = SalarioBruto * (7.5 / 100); 
            }
            else if (ValorEntre(1320.01,2571,SalarioBruto))
            {
                SalarioFinal = 99;
                SalarioFinal = SalarioBruto * (9 / 100);
            }

            else if (ValorEntre(2571.1,3856.94, SalarioBruto))
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
            SalarioBruto = SalarioFinal;
            return SalarioFinal;
        }


        public static bool ValorEntre (double valorMin, double valorMax,  double valor) 
        {
        if (valor > valorMin && valor < valorMax)
            {
                return true;
            }
        return false;
        
        }

        



    }

}
