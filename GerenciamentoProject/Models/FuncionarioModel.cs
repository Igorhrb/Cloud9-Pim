using GerenciamentoProject.Migrations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoProject.Models
{
    public class FuncionarioModel 
    {
       
       
        [Key]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int Id_funcionario { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Masculine ou Feminine")]
        public string? Sexo { get; set;}
        [Required(ErrorMessage ="Campo obrigatório")]
        public string? Endereco { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public double CPF { get; set; }
        [DisplayName("Insira o numero do PIS")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int PIS { get; set; }
        [DisplayName("Insira o seu celular com o DDD (Sem espaço)")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public double celular { get; set; }
       

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? Cargo { get; set;}
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Insira sua data de nascimento")]
        public string? Dtnascimento { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public double Salario { get; set;}
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Insira sua conta bancaria ")]
        public int ContaBanco { get; set;}

        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Insira se o funcionario é um Desenvolvedor FreeLance")]
    
        public bool Gerente { get; set; }



       


    }
}
