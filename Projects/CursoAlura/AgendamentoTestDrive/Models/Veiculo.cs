using System;
namespace AgendamentoTestDrive
{
	public class Veiculo
	{
		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public string PrecoFormatado { get { return FormatarPreco(Preco); } }


		public const decimal FREIO_ABS = 800;
		public const decimal AR_CONDICIONADO = 1000;
		public const decimal MP3_PLAYER = 500;


		public bool TemFreioAbs { get; set; }
		public bool TemArCondicionado { get; set; }
		public bool TemMp3Player { get; set; }

		public string TextoFreioAbs { get { return $"Freio ABS - {FormatarPreco(FREIO_ABS)}"; } }
		public string TextoArCondicionado { get { return $"Ar Condicionado - {FormatarPreco(AR_CONDICIONADO)}"; } }
		public string TextoMp3Player { get { return $"MP3 Player - {FormatarPreco(MP3_PLAYER)}"; } }


		public string PrecoTotalFormatado
		{
			get
			{
				var precoTotal = Preco
										+ (TemFreioAbs ? FREIO_ABS : 0)
										+ (TemArCondicionado ? AR_CONDICIONADO : 0)
										+ (TemMp3Player ? MP3_PLAYER : 0);


				return $"Valor total: {FormatarPreco(precoTotal)}";
			}
		}

		public string FormatarPreco(decimal valor)
		{
			return string.Format("R$ {0:N}", valor);
		}
	}
}
