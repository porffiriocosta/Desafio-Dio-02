namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
             var quantidade = hospedes.Count();

            if (quantidade <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("Numero de hospedes maior que o permitido");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
           var pessoas = Hospedes.Count();
            return pessoas;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = Suite.ValorDiaria;
            // Cálculo: DiasReservados X Suite.ValorDiaria
           
            decimal total = DiasReservados * valor;
            decimal percentual = 0.10M;
            decimal final = 0;
              // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%

            if (DiasReservados >= 10)
            {
                final = (DiasReservados * valor) * percentual;
                total = total - final;
            }

            return total;
        }
    }
}